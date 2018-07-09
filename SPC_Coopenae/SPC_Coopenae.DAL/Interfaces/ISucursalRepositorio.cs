using SPC_Coopenae.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC_Coopenae.DAL.Interfaces
{
    public interface ISucursalRepositorio
    {
        List<Sucursal> ListarSucursal();
        Sucursal BuscarSucursal(int id);
        void InsertarSucursal(Sucursal sucursal);
        void ActualizarSucursal(Sucursal sucursal);
        void EliminarSucursal(int id);
    }
}
