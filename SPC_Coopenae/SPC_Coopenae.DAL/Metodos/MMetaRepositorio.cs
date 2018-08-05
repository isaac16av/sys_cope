using SPC_Coopenae.DAL.Interfaces;
using SPC_Coopenae.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC_Coopenae.DAL.Metodos
{
    public class MMetaRepositorio : IMetaRepositorio
    {
        public void ActualizarMeta(Meta meta)
        {
            using (var dbc = new SPC_BD())
            {
                dbc.Entry(meta).State = EntityState.Modified;

                dbc.SaveChanges();

            }
        }

        public Meta BuscarMeta(int id)
        {
            using (var dbc = new SPC_BD())
            {
                return dbc.Meta.Find(id);
            }
        }

        public void EliminarMeta(int id)
        {
            using (var dbc = new SPC_BD())
            {
                var eMeta = dbc.Meta.Find(id);
                eMeta.Estado = false;
                dbc.SaveChanges();
            }
        }

        public void InsertarMeta(Meta meta)
        {
            using (var dbc = new SPC_BD())
            {
                var iMeta = dbc.Meta.Add(meta);
                dbc.SaveChanges();
            }
        }

        public List<Meta> ListarMetas()
        {
            using (var dbc = new SPC_BD())
            {
                return dbc.Meta.Where(x => x.Estado == true).ToList();
            }
        }
    }
}
