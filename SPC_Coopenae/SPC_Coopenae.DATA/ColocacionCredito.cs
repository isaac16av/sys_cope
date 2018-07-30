namespace SPC_Coopenae.DATA
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class ColocacionCredito
    {
        [Key]
        public int IdColocacionCredito { get; set; }
        public System.DateTime FechaFormalizacion { get; set; }
        public int Cedula { get; set; }
        public string CentroTrabajo { get; set; }
        public string Sector { get; set; }
        public System.DateTime FechaAfiliacion { get; set; }
        public int NumeroOperacion { get; set; }
        public string Sucursal { get; set; }
        public decimal MontoDesembolsado { get; set; }
        public string PlazoMeses { get; set; }
        public int TipoCredito { get; set; }
        public int Ejecutivo { get; set; }
        public int Estado { get; set; }
    }
}
