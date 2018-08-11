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
    public class MDetalleInicioRepositorio : IDetalleInicioRepositorio
    {
        public void ActualizarDetalleInicio(DetalleInicio dInicio)
        {
            using (var dbc = new SPC_BD())
            {
                dbc.Entry(dInicio).State = EntityState.Modified;
                dbc.SaveChanges();
            }
        }

        public DetalleInicio BuscarDetalleInicio(int id)
        {
            using (var dbc = new SPC_BD())
            {
                return dbc.DetalleInicio.Find(id);
            }
        }

        public void EliminarDetalleInicio(int id)
        {
            using (var dbc = new SPC_BD())
            {
                var eDetalle = dbc.DetalleInicio.Find(id);
                dbc.DetalleInicio.Remove(eDetalle);
                dbc.SaveChanges();
            }
        }

        public void InsertarDetalleInicio(DetalleInicio dInicio)
        {
            using (var dbc = new SPC_BD())
            {
                dbc.DetalleInicio.Add(dInicio);
                dbc.SaveChanges();
            }
        }

        public List<DetalleInicio> ListarDetalleInicio()
        {
            using (var dbc = new SPC_BD())
            {
                return dbc.DetalleInicio.ToList();
            }
        }
    }
}
