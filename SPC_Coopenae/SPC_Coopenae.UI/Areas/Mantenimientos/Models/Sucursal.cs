using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SPC_Coopenae.UI.Areas.Mantenimientos.Models
{
    public class Sucursal
    {
        [Display(Name = "Id sucursal")]
        public int IdSucursal { get; set; }
        [Required(ErrorMessage = "El campo nombre de sucursal es requerido")]
        public string NombreSucursal { get; set; }
        [Display(Name = "Categoría")]
        public int Categoria { get; set; }
        [Display(Name = "Estado")]
        public int Estado { get; set; }
    }
}