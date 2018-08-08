using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPC_Coopenae.DAL.Interfaces;
using SPC_Coopenae.DATA;
using System.Data.Entity;

namespace SPC_Coopenae.DAL.Metodos
{
    class MMetaCreditoRepositorio : IMetaCreditoRepositorio
    {
        public void ActualizarMetaCredito(MetaCredito metaCredito)
        {
            using (var dbc = new SPC_BD())
            {
                dbc.Entry(metaCredito).State = EntityState.Modified;

                dbc.SaveChanges();

            }
        }

        public MetaCredito BuscarMetaCredito(int id)
        {
            using (var dbc = new SPC_BD())
            {
                return dbc.MetaCredito.Find(id);
            }
        }

        public void EliminarEjecutivo(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertarMetaCredito(MetaCredito metaCredito)
        {
            using (var dbc = new SPC_BD())
            {
                dbc.MetaCredito.Add(metaCredito);
                dbc.SaveChanges();
            }
        }

        public List<MetaCredito> ListarMetaCredito()
        {
            using (var dbc = new SPC_BD())
            {
                return dbc.MetaCredito.ToList();
            }
        }
    }
}
