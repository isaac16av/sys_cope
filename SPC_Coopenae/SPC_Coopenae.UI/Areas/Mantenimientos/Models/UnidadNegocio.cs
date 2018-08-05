using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SPC_Coopenae.UI.Areas.Mantenimientos.Models
{
    public class UnidadNegocio
    {
        public int IdUnidad { get; set; }

        public char Nombre { get; set; }

        public bool Estado { get; set; }

        public int Meta { get; set; }

    }
}