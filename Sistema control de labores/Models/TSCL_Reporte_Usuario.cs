//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sistema_control_de_labores.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TSCL_Reporte_Usuario
    {
        public int TN_idReporte { get; set; }
        public Nullable<int> TN_idUsuario { get; set; }
        public Nullable<int> TN_idSubProceso { get; set; }
        public Nullable<System.DateTime> TF_RealizaTarea { get; set; }
        public Nullable<int> TN_Cantidad { get; set; }
    
        public virtual TSCL_Usuario TSCL_Usuario { get; set; }
        public virtual TSCL_SubProceso TSCL_SubProceso { get; set; }
    }
}
