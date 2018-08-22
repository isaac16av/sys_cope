using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SPC_Coopenae.UI.Areas.Mantenimientos.Models
{
    public class Salario
    {
        public int IdSalario { get; set; }

        [Required(ErrorMessage ="Este campo es obligatorio")]
        public decimal Base { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int DetalleInicio { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public bool Estado { get; set; } = true;
    }
}