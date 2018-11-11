using SPC_Coopenae.DATA;
using SPC_Coopenae.DATA.ObjReportes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC_Coopenae.BLL.Metas
{
    public class CalculaIDP
    {

        public decimal TotalIDP { get; set; }

        public MetaCredito metaCred { get; set; }
        public List<MetaTipoProducto> metaTipoProducto { get; set; }
        //hay que hacer que no se pase de la cantidad del idp, porque por ejemplo si es 70 puede que en la suma haya mas de eso
        public decimal CreditoIDP;
        public decimal ProductosIDP;

        public void FijarIDPCred(decimal montoColocado)
        {
            if (metaCred != null)
            {
                decimal porcentajeObtenido = montoColocado / metaCred.MetaColocacion;
                CreditoIDP = porcentajeObtenido * metaCred.ValorIDP;
                CreditoIDP = CreditoIDP > metaCred.ValorIDP ? metaCred.ValorIDP : CreditoIDP;
            }
            else
            {
                return;
            }
        }

        public void FijarIDPProductos(List<MetaProductosParaIDP> metaYCantidad)
        {
            ProductosIDP = 0;
            foreach (var meta in metaTipoProducto)
            {
                var correspondiente = metaYCantidad.Find(x => x.IdMeta == meta.IdMetaTipoProducto);
                decimal porcentajeObtenido;
                if (correspondiente == null)
                {
                    porcentajeObtenido = 0;
                }
                else
                {
                    porcentajeObtenido = (decimal)correspondiente.Cantidad / (decimal)meta.MetaCantidad;
                }
                
                decimal IDPProdGanado = porcentajeObtenido * meta.ValorIDP;
                IDPProdGanado = IDPProdGanado > meta.ValorIDP ? meta.ValorIDP : IDPProdGanado;
                ProductosIDP += IDPProdGanado;
            }
        }

        public void SumarIDps()
        {
            TotalIDP = 0;
            TotalIDP += CreditoIDP;
            TotalIDP += ProductosIDP;
        }


    }

}
