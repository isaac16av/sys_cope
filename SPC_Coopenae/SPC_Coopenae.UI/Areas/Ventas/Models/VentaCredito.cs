using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace SPC_Coopenae.UI.Areas.Ventas.Models
{
    public class VentaCredito
    {
        public int IdVentaCredito { get; set; }

        [Remote("ValidarEjecutivo", "ValidaEjecutivo", "", ErrorMessage = "Cédula no registrada")]
        public int Ejecutivo { get; set; }

        public DateTime Fecha { get; set; }

        public int Cedula { get; set; }

        public string Nombre { get; set; }

        public string CentroTrabajo { get; set; }

        public DateTime FechaAfiliacion { get; set; }

        public int NumeroOperacion { get; set; }

        public decimal Monto { get; set; }

        public int PlazoMeses { get; set; }

        public bool Estado { get; set; }

        public int TipoCredito { get; set; }
    }
}