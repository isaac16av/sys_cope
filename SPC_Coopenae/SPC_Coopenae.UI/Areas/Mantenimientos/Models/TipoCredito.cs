using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SPC_Coopenae.UI.Areas.Mantenimientos.Models
{
    public class TipoCredito
    {
        public int IdCredito { get; set; }
        public string NombreDeCredito { get; set; }

        public double ComisionDirefente { get; set; }
        public int Estado { get; set; }
    }
}