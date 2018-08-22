using SPC_Coopenae.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC_Coopenae.DAL.Interfaces
{
    public interface IMetaTipoProductoRepositorio
    {
        List<MetaTipoProducto> ListarMetaTipoProducto();

        MetaTipoProducto BuscarMetaTipoProducto(int id);

        void InsertarMetaTipoProducto(MetaTipoProducto metaTP);

        void ActualizarMetaTipoProducto(MetaTipoProducto metaTP);

        void EliminarMetaTipoProducto(int id);



    }
}
