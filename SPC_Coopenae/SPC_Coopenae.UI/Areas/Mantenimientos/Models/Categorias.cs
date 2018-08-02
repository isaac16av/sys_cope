using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SPC_Coopenae.UI.Areas.Mantenimientos.Models
{
    public class Categorias
    {
        [Display(Name = "Id categoria")]
        public int IdCategoria { get; set; }
        [Required(ErrorMessage = "El campo nombre es requerido")]
        public string Nombre { get; set; }
        [Display(Name = "Escala")]
        public int Escala { get; set; }
        [Display(Name = "Meta")]
        public int Meta { get; set; }
        [Display(Name = "Estado")]
        public int Estado { get; set; }
    }
}