namespace SPC_Coopenae.DATA
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class TipoCredito
    {
        [Key]
        public int IdCredito { get; set; }
        public string NombreDeCredito { get; set; }
        public decimal ComisionDirefente { get; set; }
        public int Estado { get; set; }
    }
}
