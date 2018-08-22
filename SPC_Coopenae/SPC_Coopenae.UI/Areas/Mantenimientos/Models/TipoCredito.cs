using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SPC_Coopenae.UI.Areas.Mantenimientos.Models
{
    public class TipoCredito
    {
        public int IdTipoCredito { get; set; }

        public string Nombre { get; set; }

        public decimal ComisionDistinta { get; set; }

        public decimal MaximoComision { get; set; }

        public bool SumaIDP { get; set; }

        public bool Estado { get; set; } = true;

    }
}