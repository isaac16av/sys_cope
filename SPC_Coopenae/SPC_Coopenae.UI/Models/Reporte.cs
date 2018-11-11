using SPC_Coopenae.UI.Models.ObjsReporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPC_Coopenae.UI.Models
{
    public class Reporte
    {

        public int Cedula { get; set; }

        public string Nombre { get; set; }

        public DateTime Fecha { get; set; }

        public decimal TipoCambio { get; set; }

        public List<RTipoCreditos> listaTipoCreditos { get; set; }

        public decimal? TotalComisionCreditos { get; set; }

        public List<RProductos> listaProductos { get; set; }

        public decimal TotalComisionProductos { get; set; }



        public decimal TotalComisionesGanadas { get; set; }

    }
}