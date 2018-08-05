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
    public class MVentaProductoRepositorio : IVentaProductoRepositorio
    {
        public void ActualizarVentaProducto(VentaProducto venta)
        {
            using (var dbc = new SPC_BD())
            {
                dbc.Entry(venta).State = EntityState.Modified;

                dbc.SaveChanges();

            }
        }

        public VentaProducto BuscarVentaProducto(int id)
        {
            using (var dbc = new SPC_BD())
            {
                return dbc.VentaProducto.Find(id);
            }
        }

        public void EliminarVentaProducto(int id)
        {
            using (var dbc = new SPC_BD())
            {
                VentaProducto colocacion = dbc.VentaProducto.Find(id);
                dbc.VentaProducto.Remove(colocacion);
                dbc.SaveChanges();
            }
        }

        public void InsertarVentaProducto(VentaProducto venta)
        {
            using (var dbc = new SPC_BD())
            {
                dbc.VentaProducto.Add(venta);
                dbc.SaveChanges();
            }
        }

        public List<VentaProducto> ListarVentasProducto()
        {
            using (var dbc = new SPC_BD())
            {
                return dbc.VentaProducto.ToList();
            }
        }

    }
}
