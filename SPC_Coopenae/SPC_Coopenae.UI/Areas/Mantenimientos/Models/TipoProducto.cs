using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SPC_Coopenae.UI.Areas.Mantenimientos.Models
{
    public class TipoProducto
    {
        [Display(Name = "Id Tipo Producto")]
        public int IdTipoProducto { get; set; }
        [Required(ErrorMessage = "El campo descripción es requerido")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "El campo moneda es requerido")]
        public string Moneda { get; set; }

        public bool Estado { get; set; }
    }
}