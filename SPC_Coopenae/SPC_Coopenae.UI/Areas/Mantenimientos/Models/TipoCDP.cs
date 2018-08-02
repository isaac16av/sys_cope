using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPC_Coopenae.UI.Areas.Mantenimientos.Models
{
    public class TipoCDP
    {
        public int IdTipoCDP { get; set; }

        public string Nombre { get; set; }

        public string Moneda { get; set; }

        public decimal Comision { get; set; }

        public int Estado { get; set; }

    }
}