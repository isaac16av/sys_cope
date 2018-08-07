using SPC_Coopenae.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPC_Coopenae.UI
{
    public class ParametrosConfig
    {
        public static void IniciarParametros()
        {
            TipoDeCambioActual.FijarTipoDeCambio();
        }
    }
}