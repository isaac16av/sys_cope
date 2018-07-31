using SPC_Coopenae.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC_Coopenae.DAL.Interfaces
{
    public interface IAfiliacionRepositorio
    {
        List<Afiliaciones> ListarAfiliaciones();
        Afiliaciones BuscarAfiliacion(int id);
        void InsertarAfiliacion(Afiliaciones a);
        void ActualizarAfiliacion(Afiliaciones a);
        void EliminarAfiliacion(int id);
    }
}
