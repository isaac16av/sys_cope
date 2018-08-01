using SPC_Coopenae.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC_Coopenae.DAL.Interfaces
{
    public interface IColocacionCDPRepositorio
    {
        List<ColocacionCDP> ListarCDP();
        ColocacionCDP BuscarCDP(int id);
        void InsertarCDP(ColocacionCDP cdp);
        void ActualizarCDP(ColocacionCDP cdp);
        void EliminarCDP(int id);
    }
}
