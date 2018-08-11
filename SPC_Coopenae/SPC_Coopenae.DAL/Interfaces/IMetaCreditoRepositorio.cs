using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPC_Coopenae.DATA;

namespace SPC_Coopenae.DAL.Interfaces
{
    interface IMetaCreditoRepositorio
    {
        List<MetaCredito> ListarMetaCredito();
        MetaCredito BuscarMetaCredito(int id);
        void InsertarMetaCredito(MetaCredito metaCredito);
        void ActualizarMetaCredito(MetaCredito metaCredito);
        void EliminarEjecutivo(int id);
    }
}
