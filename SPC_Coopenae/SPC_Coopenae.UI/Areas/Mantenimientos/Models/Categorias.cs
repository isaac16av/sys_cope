using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPC_Coopenae.UI.Areas.Mantenimientos.Models
{
    public class Categorias
    {
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public int Escala { get; set; }
        public int Meta { get; set; }
        public int Estado { get; set; }
    }
}