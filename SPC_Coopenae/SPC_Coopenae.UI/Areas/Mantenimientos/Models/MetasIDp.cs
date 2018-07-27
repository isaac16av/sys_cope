using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPC_Coopenae.UI.Areas.Mantenimientos.Models
{
    public class MetasIDP
    {
        public int IdMeta { get; set; }
        public decimal Creditos { get; set; }
        public int OtrosProductos { get; set; }
        public int TarjetasCredito { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }
        public decimal MinimoComisionarCDP { get; set; }
    }
}