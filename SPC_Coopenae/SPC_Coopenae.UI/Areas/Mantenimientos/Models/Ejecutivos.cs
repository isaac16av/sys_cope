using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SPC_Coopenae.UI.Areas.Mantenimientos.Models
{
    public class Ejecutivos
    {
        [Display(Name = "Cédula")]
        [MaxLength(10, ErrorMessage = "El número máximo son 10 dígitos")]
        public int Cedula { get; set; }
        [Required(ErrorMessage = "El campo nombre es requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo apellidos es requerido")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "El campo sexo es requerido")]
        public string Sexo { get; set; }
        [Required(ErrorMessage = "El campo telefono es requerido")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El campo correo es requerido")]
        [EmailAddress(ErrorMessage = "No cumple con la estructura de correo válido")]
        public string Correo { get; set; }
        [Required(ErrorMessage = "El campo código de vendedor es requerido")]
        public string CodigoVendedor { get; set; }
        [Required(ErrorMessage = "El campo residencia es requerido")]
        public string Residencia { get; set; }
        [Display(Name = "Sucursal")]
        public int Sucursal { get; set; }
        public System.DateTime FechaNacimiento { get; set; }
        public System.DateTime FechaContratacion { get; set; }
        [Display(Name = "Estado")]
        public int Estado { get; set; }
        [Display(Name = "Meta aparte")]
        public int MetaAparte { get; set; }
        [Display(Name = "Salario")]
        public int Salario { get; set; }

    }
}