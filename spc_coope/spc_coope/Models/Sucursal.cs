//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace spc_coope.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sucursal
    {
        public int IdSucursal { get; set; }
        public string Provincia { get; set; }
        public string Canton { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> Categoria { get; set; }
    }
}