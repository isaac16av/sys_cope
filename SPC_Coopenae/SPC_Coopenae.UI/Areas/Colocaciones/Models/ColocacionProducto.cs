using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SPC_Coopenae.UI.Areas.Colocaciones.Models
{
    public class ColocacionProducto
    {
        [Display(Name = "Id colocación de producto")]
        public int IdColocacionProducto { get; set; }
        
        public System.DateTime Fecha { get; set; }
        [Display(Name = "Cédula")]
        [MaxLength(10, ErrorMessage = "El número máximo son 10 dígitos")]
        public int Cedula { get; set; }
        [Required(ErrorMessage = "El campo nombre es requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo centro de trabajo es requerido")]
        public string CentroTrabajo { get; set; }
        [Display(Name = "Producto")]
        public int Producto { get; set; }

        [Remote("ValidarEjecutivo", "ValidaEjecutivo", "", ErrorMessage = "Cédula no registrada")]
        public int Ejecutivo { get; set; }
        public int Estado { get; set; }
    }
}