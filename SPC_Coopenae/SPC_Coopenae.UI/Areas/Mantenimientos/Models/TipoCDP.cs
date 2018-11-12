using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SPC_Coopenae.UI.Areas.Mantenimientos.Models
{
    public class TipoCDP
    {
        public int IdTipoCDP { get; set; }

        public string Nombre { get; set; }

        public string Moneda { get; set; }

        [Display(Name = "Comisión Máxima")]
        public decimal ComisionMaxima { get; set; }

        [Display(Name = "Plazo (Meses)")]
        public int PlazoMesesMaximo { get; set; }

        public bool Estado { get; set; } = true;

        [Display(Name = "IDP Necesario para comisión")]
        public decimal IDPNecesario { get; set; }

    }
}