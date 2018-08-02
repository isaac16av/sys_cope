using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SPC_Coopenae.UI.Areas.Mantenimientos.Models
{
    public class MetasIDP
    {
        [Display(Name = "Id de meta")]
        public int IdMeta { get; set; }
        [Display(Name = "Créditos")]
        public decimal Creditos { get; set; }
        [Display(Name = "Otros productos")]
        public int OtrosProductos { get; set; }
        [Display(Name = "Tarjetas de credito")]
        public int TarjetasCredito { get; set; }
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        [Display(Name = "Estado")]
        public int Estado { get; set; }
        [Display(Name = "Mínimo de condición")]
        public decimal MinimoComisionarCDP { get; set; }
    }
}