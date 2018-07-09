using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPC_Coopenae.UI.Areas.Mantenimientos.Models
{
    public class Sucursal
    {
        public int IdSucursal { get; set; }
        public string Provincia { get; set; }
        public string Canton { get; set; }
        public string Descripcion { get; set; }
        public int Categoria { get; set; }
        public int Estado { get; set; }
    }
}