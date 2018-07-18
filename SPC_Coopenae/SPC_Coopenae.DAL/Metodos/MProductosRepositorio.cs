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
    public class MProductosRepositorio : IProductosRepositorio
    {
        public void ActualizarProductos(Productos productos)
        {
            using (var dbc = new ConexionBD())
            {
                dbc.Entry(productos).State = EntityState.Modified;
                dbc.SaveChanges();
            }
        }

        public Productos BuscarProductos(int id)
        {
            using (var dbc = new ConexionBD())
            {
                return dbc.Productos.Find(id);
            }
        }

        public void EliminarProductos(int id)
        {
            using (var dbc = new ConexionBD())
            {
                var aEliminar = dbc.Productos.Find(id);
                aEliminar.Estado = 0;
                dbc.SaveChanges();
            }
        }

        public void InsertarProductos(Productos productos)
        {
            using (var dbc = new ConexionBD())
            {
                dbc.Productos.Add(productos);
                dbc.SaveChanges();
            }
        }

        public List<Productos> ListarProductos()
        {
            using (var dbc = new ConexionBD())
            {
                return dbc.Productos.Where(x => x.Estado == 1).ToList();
            }
        }
    }
}
