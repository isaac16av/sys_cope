namespace SPC_Coopenae.DATA
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Productos
    {
        [Key]
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public decimal ComisionGenera { get; set; }
        public int EsDolar { get; set; }
        public int Estado { get; set; }
    }
}
