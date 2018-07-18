using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPC_Coopenae.UI.Areas.Mantenimientos.Models
{
    public class Productos
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public double ComisionGenera { get; set; }
        public int EsDolar { get; set; }
        public int Estado { get; set; }

    }
}