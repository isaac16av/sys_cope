using SPC_Coopenae.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC_Coopenae.DAL.Interfaces
{
    public interface ICategoriaRepositorio
    {
        List<Categorias> ListarCategorias();
        Categorias BuscarCategoria(int id);
        void InsertarCategoria(Categorias categoria);
        void ActualizarCategoria(Categorias categoria);
        void EliminarCategoria(int id);
    }
}
