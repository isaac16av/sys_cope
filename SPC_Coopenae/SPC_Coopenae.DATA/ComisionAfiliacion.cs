using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC_Coopenae.DATA
{
    public class ComisionAfiliacion
    {
        [Key]
        public int IdComisionAfiliacion { get; set; }

        public decimal Comision { get; set; }

    }

}
