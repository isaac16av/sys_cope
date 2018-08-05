using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPC_Coopenae.UI.Areas.Ventas.Models
{
    public class VentaCDP
    {
        
        public int IdVentaCDP { get; set; }

        [Remote("ValidarEjecutivo", "ValidaEjecutivo", "", ErrorMessage = "Cédula no registrada")]
        public int Ejecutivo { get; set; }

        public DateTime Fecha { get; set; }

        public int Cedula { get; set; }

        public string Nombre { get; set; }

        public string CentroTrabajo { get; set; }

        public decimal Monto { get; set; }

        public int PlazoMeses { get; set; }

        public int Periocidad { get; set; }

        public decimal? Tasa { get; set; }

        public decimal? SobreTasa { get; set; }

        public bool Estado { get; set; }

        public int TipoCDP { get; set; }

    }
}