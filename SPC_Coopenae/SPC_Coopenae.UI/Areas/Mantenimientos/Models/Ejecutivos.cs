using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SPC_Coopenae.UI.Areas.Mantenimientos.Models
{
    public class Ejecutivos
    {
        [Required]
        public int Cedula { get; set; }

        [Required] [MinLength(2)]
        public string Nombre { get; set; }

        [Required] [MinLength(2)]
        public string Apellidos { get; set; }
        public string Sexo { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string CodigoVendedor { get; set; }
        public string Residencia { get; set; }
        public int Sucursal { get; set; }
        public System.DateTime FechaNacimiento { get; set; }
        public System.DateTime FechaContratacion { get; set; }
        public int Estado { get; set; }

    }
}