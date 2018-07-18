using SPC_Coopenae.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC_Coopenae.DAL.Interfaces
{
    public interface IProductosRepositorio
    {
        List<Productos> ListarProductos();
        Productos BuscarProductos(int id);
        void InsertarProductos(Productos productos);
        void ActualizarProductos(Productos productos);
        void EliminarProductos(int id);

    }
}
