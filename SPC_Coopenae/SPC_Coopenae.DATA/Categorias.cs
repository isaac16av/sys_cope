namespace SPC_Coopenae.DATA
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Categorias
    {
        [Key]
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public int Escala { get; set; }
        public int Meta { get; set; }
        public int Estado { get; set; }
    }
}
