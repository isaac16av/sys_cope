using SPC_Coopenae.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC_Coopenae.DAL.Interfaces
{
    public interface IMetaRepositorio
    {
        List<MetasIDP> ListarMetasIDP();
        MetasIDP BuscarMeta(int id);
        void InsertarMeta(MetasIDP meta);
        void ActualizarMeta(MetasIDP meta);
        void EliminarMeta(int id);
    }
}
