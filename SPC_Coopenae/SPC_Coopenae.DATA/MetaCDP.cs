using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SPC_Coopenae.DATA
{
    public class MetaCDP
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdMetaCDP { get; set; }

        public decimal Metacdp { get; set; }

        public decimal ValorIDP { get; set; }

        public int Meta { get; set; }

    }
}
