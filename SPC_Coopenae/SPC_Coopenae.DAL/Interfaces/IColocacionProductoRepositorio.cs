using SPC_Coopenae.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC_Coopenae.DAL.Interfaces
{
    public interface IColocacionProductoRepositorio
    {

        List<ColocacionProducto> ListarColocacionesProducto();
        List<ColocacionProducto> ListarColocacionesProductoPorEjecutivo(int cedula);
        ColocacionProducto BuscarColocacionProducto(int id);
        void InsertarColocacionProducto(ColocacionProducto colocacion);
        void ActualizarColocacionProducto(ColocacionProducto colocacion);
        void EliminarColocacionProducto(int id);

    }
}
