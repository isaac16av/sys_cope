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
    public class MAfiliacionRepositorio : IAfiliacionRepositorio
    {
        public void ActualizarAfiliacion(Afiliaciones a)
        {
            using (var dbc = new SPC_BD())
            {
                dbc.Entry(a).State = EntityState.Modified;

                dbc.SaveChanges();
            }
        }

        public Afiliaciones BuscarAfiliacion(int id)
        {
            using (var dbc = new SPC_BD())
            {
                return dbc.Afiliaciones.Find(id);
            }
        }

        public void EliminarAfiliacion(int id)
        {
            using (var dbc = new SPC_BD())
            {
                var eAfiliacion = dbc.Afiliaciones.Find(id);
                eAfiliacion.Estado = 0;
                dbc.SaveChanges();
            }
        }

        public void InsertarAfiliacion(Afiliaciones a)
        {
            using (var dbc = new SPC_BD())
            {
                dbc.Afiliaciones.Add(a);

                dbc.SaveChanges();
            }
        }

        public List<Afiliaciones> ListarAfiliaciones()
        {
            using (var dbc = new SPC_BD())
            {
                return dbc.Afiliaciones.ToList();
            }
        }
    }
}
