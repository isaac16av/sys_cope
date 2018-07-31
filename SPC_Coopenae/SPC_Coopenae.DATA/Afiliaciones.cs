using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC_Coopenae.DATA
{
    public class Afiliaciones
    {
        [Key]
        public int IdAfiliacion { get; set; }

        public DateTime Fecha { get; set; }

        public int Cedula { get; set; }

        public string Nombre { get; set; }

        public string CentroTrabajo { get; set; }

        public string Sucursal { get; set; }

        public DateTime FechaAfiliacion { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public int Comision { get; set; }

        public int Ejecutivo { get; set; }

        public int Estado { get; set; }

    }


}
