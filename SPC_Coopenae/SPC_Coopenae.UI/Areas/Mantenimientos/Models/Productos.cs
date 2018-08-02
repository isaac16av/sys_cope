using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SPC_Coopenae.UI.Areas.Mantenimientos.Models
{
    public class Productos
    {
        [Display(Name = "Id de prodcuto")]
        public int IdProducto { get; set; }
        [Required(ErrorMessage = "El campo nombre es requerido")]
        public string Nombre { get; set; }
        [Display(Name = "Comisión general")]
        public decimal ComisionGenera { get; set; }
        [Display(Name = "Estado del dolar")]
        public int EsDolar { get; set; }
        [Display(Name = "Estado")]
        public int Estado { get; set; }

    }
}