using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC_Coopenae.DATA
{
    public class ColocacionCDP
    {
        [Key]
        public int IdColocacionCDP { get; set; }

        public DateTime Fecha { get; set; }

        public int NumeroTitulo { get; set; }

        public int Cedula { get; set; }

        public string Nombre { get; set; }

        public string CentroTrabajo { get; set; }

        public DateTime FechaEmision { get; set; }

        public string Sucursal { get; set; }

        public string Periocidad { get; set; }

        public decimal MontoCDP { get; set; }

        public int PlazoMeses { get; set; }

        public decimal TasaOtorgada { get; set; }

        public decimal SobreTasa { get; set; }

        public int Ejecutivo { get; set; }

        public int Estado { get; set; }

        public int TipoCDP { get; set; }

    }
}
