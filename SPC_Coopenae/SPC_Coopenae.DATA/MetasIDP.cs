namespace SPC_Coopenae.DATA
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class MetasIDP
    {
        [Key]
        public int IdMeta { get; set; }
        public decimal Creditos { get; set; }
        public int OtrosProductos { get; set; }
        public int TarjetasCredito { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }
        public decimal MinimoComisionarCDP { get; set; }
    }
}
