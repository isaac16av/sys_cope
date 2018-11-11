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
    public class MVentaCreditoRepositorio : IVentaCreditoRepositorio
    {
        public void ActualizarVentaCredito(VentaCredito venta)
        {
            using (var dbc = new SPC_BD())
            {
                dbc.Entry(venta).State = EntityState.Modified;

                dbc.SaveChanges();

            }
        }

        public VentaCredito BuscarVentaCredito(int id)
        {
            using (var dbc = new SPC_BD())
            {
                return dbc.VentaCredito.Find(id);
            }
        }

        public void EliminarVentaCredito(int id)
        {
            using (var dbc = new SPC_BD())
            {
                var eColCred = dbc.VentaCredito.Find(id);
                dbc.VentaCredito.Remove(eColCred);

                dbc.SaveChanges();
            }
        }

        public void InsertarVentaCredito(VentaCredito venta)
        {
            using (var dbc = new SPC_BD())
            {
                dbc.VentaCredito.Add(venta);

                dbc.SaveChanges();
            }
        }

        public List<VentaCredito> ListarVentaCredito()
        {
            using (var dbc = new SPC_BD())
            {
                return dbc.VentaCredito.ToList();
            }
        }

        public List<VentaCredito> BuscarListaCreditos(int ejecutivo, DateTime fecha)
        {
            using (var dbc = new SPC_BD())
            {
                return (from creditos in dbc.VentaCredito
                        where creditos.Ejecutivo == ejecutivo &&
                        creditos.Fecha.Month == fecha.Month &&
                        creditos.Fecha.Year == fecha.Year
                        select creditos).ToList();
            }
        }




    }
}
