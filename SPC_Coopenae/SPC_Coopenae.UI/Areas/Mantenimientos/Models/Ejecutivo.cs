using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SPC_Coopenae.UI.Areas.Mantenimientos.Models
{
    public class Ejecutivo
    {
        [Display(Name = "Cédula")]
        public int Cedula { get; set; }

        [Required(ErrorMessage = "El campo código de vendedor es requerido")]
        public string CodigoVendedor { get; set; }

        [Required(ErrorMessage = "El campo nombre es requerido")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo apellidos es requerido")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "El campo telefono es requerido")]
        public int Telefono { get; set; }

        [Required(ErrorMessage = "El campo correo es requerido")]
        [EmailAddress(ErrorMessage = "No cumple con la estructura de correo válido")]
        public string Correo { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public DateTime FechaContratacion { get; set; }

        public bool Estado { get; set; }
        [Display(Name = "Unidad De Negocio")]

        public int UnidadNegocio { get; set; }

    }
}