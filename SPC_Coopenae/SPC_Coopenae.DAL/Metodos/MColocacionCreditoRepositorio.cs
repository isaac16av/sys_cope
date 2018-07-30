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
    public class MColocacionCreditoRepositorio : IColocacionCreditoRepositorio
    {
        public void ActualizarColocacionCredito(ColocacionCredito colCred)
        {
            using (var dbc = new SPC_BD())
            {
                dbc.Entry(colCred).State = EntityState.Modified;

                dbc.SaveChanges();

            }
        }

        public ColocacionCredito BuscarColocacionCredito(int id)
        {
            using (var dbc = new SPC_BD())
            {
                return dbc.ColocacionCredito.Find(id);
            }
        }

        public void EliminarColocacionCredito(int id)
        {
            using (var dbc = new SPC_BD())
            {
                var eColCred = dbc.ColocacionCredito.Find(id);
                dbc.ColocacionCredito.Remove(eColCred);

                dbc.SaveChanges();
            }
        }

        public void InsertarColocacionCredito(ColocacionCredito colCred)
        {
            using (var dbc = new SPC_BD())
            {
                dbc.ColocacionCredito.Add(colCred);

                dbc.SaveChanges();
            }
        }

        public List<ColocacionCredito> ListarColocacionCredito()
        {
            using (var dbc = new SPC_BD())
            {
                return dbc.ColocacionCredito.ToList();
            }
        }
    }
}
