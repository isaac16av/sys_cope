using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPC_Coopenae.DATA;

namespace SPC_Coopenae.DAL.Interfaces
{
    interface IMetaCDPRepositorio
    {
        List<MetaCDP> ListarMetaCDP();
        MetaCDP BuscarMetaCDP(int id);
        void InsertarMetaCDP(MetaCDP metaCDP);
        void ActualizarMetaCDP(MetaCDP metaCDP);
        void EliminarMetaCDP(int id);
      
    }
}
