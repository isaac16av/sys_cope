using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPC_Coopenae.UI.Areas.Colocaciones.Models
{
    public class ColocacionProducto
    {
        public int IdColocacionProducto { get; set; }
        public System.DateTime Fecha { get; set; }
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public string CentroTrabajo { get; set; }
        public int Producto { get; set; }
        public int Ejecutivo { get; set; }
        public int Estado { get; set; }
    }
}