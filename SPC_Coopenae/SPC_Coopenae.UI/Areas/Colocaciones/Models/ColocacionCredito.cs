using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace SPC_Coopenae.UI.Areas.Colocaciones.Models
{
    public class ColocacionCredito
    {
        [Display(Name = "Id de colocaion de credito", Description = "Colocacion")]
        public int IdColocacionCredito { get; set; }
        [Display(Name = "Fecha de formalización")]
        public System.DateTime FechaFormalizacion { get; set; }
        [Required(ErrorMessage = "El campo de cedula es requerido")]
        [MaxLength(10, ErrorMessage = "El número máximo son 10 dígitos")]
        public int Cedula { get; set; }
        [Required(ErrorMessage = "El campo centro de trabajo es requerido")]
        public string CentroTrabajo { get; set; }
        [Required(ErrorMessage = "El campo sector es requerido")]
        public string Sector { get; set; }
        
        public System.DateTime FechaAfiliacion { get; set; }
        [Display(Name = "Número de operación")]
        public int NumeroOperacion { get; set; }
        [Required(ErrorMessage = "El campo sucursal es requerido")]
        public string Sucursal { get; set; }
        [Display(Name = "monto desembolsado")]
        public decimal MontoDesembolsado { get; set; }
        [Required(ErrorMessage = "El campo plazo de meses es requerido")]
        public string PlazoMeses { get; set; }
        [Display(Name = "Tipo de crédito")]
        public int TipoCredito { get; set; }

        [Remote("ValidarEjecutivo", "ValidaEjecutivo", "", ErrorMessage = "Cédula no registrada")]
        public int Ejecutivo { get; set; }
        public int Estado { get; set; }
    }
}