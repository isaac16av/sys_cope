using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPC_Coopenae.UI.Areas.Mantenimientos.Models
{
    public class ColocacionCredito
    {
        public int IdColocacionCredito { get; set; }
        public System.DateTime FechaFormalizacion { get; set; }
        public int Cedula { get; set; }
        public string CentroTrabajo { get; set; }
        public string Sector { get; set; }
        public System.DateTime FechaAfiliacion { get; set; }
        public int NumeroOperacion { get; set; }
        public string Sucursal { get; set; }
        public double MontoDesembolsado { get; set; }
        public string PlazoMeses { get; set; }
        public int TipoCredito { get; set; }
        public int Ejecutivo { get; set; }
    }
}