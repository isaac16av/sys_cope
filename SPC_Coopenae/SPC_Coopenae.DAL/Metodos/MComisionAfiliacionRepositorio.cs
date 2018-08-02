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
    public class MComisionAfiliacionRepositorio : IComisionAfiliacionRepositorio
    {
        public void ActualizarComisionAfiliacion(ComisionAfiliacion comA)
        {
            using (var dbc = new SPC_BD())
            {
                dbc.Entry(comA).State = EntityState.Modified;

                dbc.SaveChanges();
            }
        }

        public ComisionAfiliacion BuscarComisionAfiliacion(int id)
        {
            using (var dbc = new SPC_BD())
            {
                return dbc.ComisionAfiliacion.Find(id);
            }
        }

        public void EliminarComisionAfiliacion(int id)
        {
            using (var dbc = new SPC_BD())
            {
                var eComisionAfiliacion = dbc.ComisionAfiliacion.Find(id);
                dbc.ComisionAfiliacion.Remove(eComisionAfiliacion);

                dbc.SaveChanges();
            }
        }

        public void InsertarComisionAfiliacion(ComisionAfiliacion comA)
        {
            using (var dbc = new SPC_BD())
            {
                dbc.ComisionAfiliacion.Add(comA);

                dbc.SaveChanges();
            }
        }

        public List<ComisionAfiliacion> ListarComisionAfiliacion()
        {
            using (var dbc = new SPC_BD())
            {
                return dbc.ComisionAfiliacion.ToList();
            }
        }
    }
}
