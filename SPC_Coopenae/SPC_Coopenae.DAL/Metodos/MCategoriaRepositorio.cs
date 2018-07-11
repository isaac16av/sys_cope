using SPC_Coopenae.DAL.Interfaces;
using SPC_Coopenae.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC_Coopenae.DAL.Metodos
{
    public class MCategoriaRepositorio : ICategoriaRepositorio
    {
        public void ActualizarCategoria(Categorias categoria)
        {
            //pendiente
        }

        public Categorias BuscarCategoria(int id)
        {
            using (var dbc = new ConexionBD())
            {
                return dbc.Categorias.Find(id);
            }
        }

        public void EliminarCategoria(int id)
        {
            using (var dbc = new ConexionBD())
            {
                var aEliminar = dbc.Categorias.Find(id);
                aEliminar.Estado = 0;
                dbc.SaveChanges();
            }
        }

        public void InsertarCategoria(Categorias categoria)
        {
            using (var dbc = new ConexionBD())
            {
                dbc.Categorias.Add(categoria);
                dbc.SaveChanges();
            }
        }

        public List<Categorias> ListarCategorias()
        {
            using (var dbc = new ConexionBD())
            {
                return dbc.Categorias.Where(x => x.Estado == 1).ToList();
            }
        }
    }
}
