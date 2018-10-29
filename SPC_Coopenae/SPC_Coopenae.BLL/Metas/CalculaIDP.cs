using SPC_Coopenae.DATA;
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

        #region Calcular IDP para Creditos
        public MetaCredito metaCred { get; set; }
        public decimal CreditoIDP;

        public void FijarIDPCred(decimal montoColocado)
        {
            if (metaCred != null)
            {
                decimal porcentajeObtenido = montoColocado / metaCred.MetaColocacion;
                CreditoIDP = porcentajeObtenido * metaCred.ValorIDP;
                SumarIDps();
            }
            else
            {
                return;
            }
        }

        public void FijarIdpProductos()
        {

        }

        private void SumarIDps()
        {
            TotalIDP = 0;
            TotalIDP += CreditoIDP;
        }
        #endregion

    }

}
