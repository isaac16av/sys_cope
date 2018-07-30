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
    public class MCategoriaRepositorio : ICategoriaRepositorio
    {
        public void ActualizarCategoria(Categorias categoriaP)
        {
            using (var dbc = new SPC_BD())
            {
                dbc.Entry(categoriaP).State = EntityState.Modified;

                dbc.SaveChanges();

            }
        }

        public Categorias BuscarCategoria(int id)
        {
            using (var dbc = new SPC_BD())
            {
                return dbc.Categorias.Find(id);
            }
        }

        public void EliminarCategoria(int id)
        {
            using (var dbc = new SPC_BD())
            {
                var aEliminar = dbc.Categorias.Find(id);
                aEliminar.Estado = 0;
                dbc.SaveChanges();
            }
        }

        public void InsertarCategoria(Categorias categoriaP)
        {
            using (var dbc = new SPC_BD())
            {
                dbc.Categorias.Add(categoriaP);
                dbc.SaveChanges();
            }
        }

        public List<Categorias> ListarCategorias()
        {
            using (var dbc = new SPC_BD())
            {
                return dbc.Categorias.Where(x => x.Estado == 1).ToList();
            }
        }
    }
}
