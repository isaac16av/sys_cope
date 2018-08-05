using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SPC_Coopenae.UI.Areas.Ventas.Models
{
    public class VentaProducto
    {
        public int IdVentaProducto { get; set; }

        [Remote("ValidarEjecutivo", "ValidaEjecutivo", "", ErrorMessage = "Cédula no registrada")]
        public int Ejecutivo { get; set; }

        public DateTime Fecha { get; set; }

        public int Cedula { get; set; }

        public string Nombre { get; set; }

        public string CentroTrabajo { get; set; }

        public int Producto { get; set; }

        public bool Estado { get; set; }

    }
}