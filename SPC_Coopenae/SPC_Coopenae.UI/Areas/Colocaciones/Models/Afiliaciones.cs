using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPC_Coopenae.UI.Areas.Colocaciones.Models
{
    public class Afiliaciones
    {
        public int IdAfiliacion { get; set; }

        public DateTime Fecha { get; set; }

        public int Cedula { get; set; }

        public string Nombre { get; set; }

        public string CentroTrabajo { get; set; }

        public string Sucursal { get; set; }

        public DateTime FechaAfiliacion { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public int Comision { get; set; }

        [Remote("ValidarEjecutivo", "ValidaEjecutivo", "", ErrorMessage = "Cédula no registrada")]
        public int Ejecutivo { get; set; }

        public int Estado { get; set; }
    }
}