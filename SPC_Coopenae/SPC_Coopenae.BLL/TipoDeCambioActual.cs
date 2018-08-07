using SPC_Coopenae.DAL.Interfaces;
using SPC_Coopenae.DAL.Metodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC_Coopenae.BLL
{
    public class TipoDeCambioActual
    {

        public static decimal Valor { get; set; }

        public static void FijarTipoDeCambio()
        {
            try
            {
                ITipoCambio _tipoCambioBD;
                _tipoCambioBD = new MTipoCambio();

                var listaTiposCambio = _tipoCambioBD.ListarTipoCambio();
                var fechaActual = DateTime.Now;

                var tipoCambioActual = (from x in listaTiposCambio
                                        where (x.Fecha.Month == fechaActual.Month) &&
                                              (x.Fecha.Year == fechaActual.Year) &&
                                              (x.Estado == true)
                                        select x.Valor)
                                       .FirstOrDefault();

                Valor = Convert.ToDecimal(tipoCambioActual);

            }
            catch (Exception)
            {
                return;
            }
        }

    }
}
