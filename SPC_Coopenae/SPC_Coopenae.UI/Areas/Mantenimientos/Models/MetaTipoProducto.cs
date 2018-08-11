using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SPC_Coopenae.UI.Areas.Mantenimientos.Models
{
    public class MetaTipoProducto
    {
        
        public int IdMetaTipoProducto { get; set; }

        [Required(ErrorMessage ="El campo es obligatorio")]
        public int MetaCantidad { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        public decimal ValorIDP { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        public int Meta { get; set; }
    }
}