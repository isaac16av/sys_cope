namespace SPC_Coopenae.DATA
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Ejecutivos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Sexo { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string CodigoVendedor { get; set; }
        public string Residencia { get; set; }
        public int Sucursal { get; set; }
        public System.DateTime FechaNacimiento { get; set; }
        public System.DateTime FechaContratacion { get; set; }
        public int Estado { get; set; }
        public int MetaAparte { get; set; }
        public int Salario { get; set; }
    }
}
