using SPC_Coopenae.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC_Coopenae.DAL.Interfaces
{
    public interface IMetaTipoProductoDetalleRepositorio
    {
        List<MetaTipoProductoDetalle> ListarMetaTipoProductoDetalle();

        void InsertarMetaTipoProductoDetalle(MetaTipoProductoDetalle mtpd);
    }
}
