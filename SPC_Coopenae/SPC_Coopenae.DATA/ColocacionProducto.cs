namespace SPC_Coopenae.DATA
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class ColocacionProducto
    {
        [Key]
        public int IdColocacionProducto { get; set; }
        public System.DateTime Fecha { get; set; }
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public string CentroTrabajo { get; set; }
        public int Producto { get; set; }
        public int Ejecutivo { get; set; }
        public int Estado { get; set; }
    }
}
