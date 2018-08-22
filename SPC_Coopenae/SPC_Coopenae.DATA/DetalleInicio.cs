using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC_Coopenae.DATA
{
    public class DetalleInicio
    {
        [Key]
        public int IdDetalleInicio { get; set; }

        public int MesesDuracion { get; set; }

        public decimal SalarioInicio { get; set; }

        public decimal Bono { get; set; }

    }
}
