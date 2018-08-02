using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SPC_Coopenae.UI.Areas.Mantenimientos.Models
{
    public class TipoCredito
    {
        [Display(Name = "Id de crédito")]
        public int IdCredito { get; set; }
        [Required(ErrorMessage = "El campo nombre de crédito es requerido")]
        public string NombreDeCredito { get; set; }
        [Display(Name = "Comisión diferente")]
        public decimal ComisionDirefente { get; set; }
        public int Estado { get; set; }
    }
}