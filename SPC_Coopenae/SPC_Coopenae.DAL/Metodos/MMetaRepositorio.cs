using SPC_Coopenae.DAL.Interfaces;
using SPC_Coopenae.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC_Coopenae.DAL.Metodos
{
    public class MMetaRepositorio : IMetaRepositorio
    {
        public void ActualizarMeta(MetasIDP meta)
        {
          //pendiente
        }

        public MetasIDP BuscarMeta(int id)
        {
            using (var dbc = new ConexionBD())
            {
                return dbc.MetasIDP.Find(id);
            }
        }

        public void EliminarMeta(int id)
        {
            using (var dbc = new ConexionBD())
            {
                var eMeta = dbc.MetasIDP.Find(id);
                eMeta.Estado = 0;
                dbc.SaveChanges();
            }
        }

        public void InsertarMeta(MetasIDP meta)
        {
            using (var dbc = new ConexionBD())
            {
                var iMeta = dbc.MetasIDP.Add(meta);
                dbc.SaveChanges();
            }
        }

        public List<MetasIDP> ListarMetasIDP()
        {
            using (var dbc = new ConexionBD())
            {
                return dbc.MetasIDP.Where(x => x.Estado == 1).ToList();
            }
        }
    }
}
