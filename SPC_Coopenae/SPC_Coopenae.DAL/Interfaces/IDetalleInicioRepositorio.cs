using SPC_Coopenae.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC_Coopenae.DAL.Interfaces
{
    public interface IDetalleInicioRepositorio
    {
        List<DetalleInicio> ListarDetalleInicio();
        DetalleInicio BuscarDetalleInicio(int id);
        void InsertarDetalleInicio(DetalleInicio dInicio);
        void ActualizarDetalleInicio(DetalleInicio dInicio);
        void EliminarDetalleInicio(int id);
    }
}
