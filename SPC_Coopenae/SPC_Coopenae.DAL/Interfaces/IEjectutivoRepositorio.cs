using SPC_Coopenae.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC_Coopenae.DAL.Interfaces
{
    public interface IEjectutivoRepositorio
    {
        List<Ejecutivos> ListarEjecutivos();
        Ejecutivos BuscarEjecutivo(int cedula);
        void InsertarEjecutivo(Ejecutivos ejecutivo);
        void ActualizarEjecutivo(Ejecutivos ejecutivo);
        void EliminarEjecutivo(int cedula);

    }
}
