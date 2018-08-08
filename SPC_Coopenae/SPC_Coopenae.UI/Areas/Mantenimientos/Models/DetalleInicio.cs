using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SPC_Coopenae.UI.Areas.Mantenimientos.Models
{
    public class DetalleInicio
    {
        public int IdDetalleInicio { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int MesesDuracion { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public decimal SalarioInicio { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public decimal Bono { get; set; }
    }
}