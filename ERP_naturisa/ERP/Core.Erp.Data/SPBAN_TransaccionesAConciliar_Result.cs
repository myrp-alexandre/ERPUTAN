//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    
    public partial class SPBAN_TransaccionesAConciliar_Result
    {
        public long IdRow { get; set; }
        public int IdEmpresa { get; set; }
        public decimal IdConciliacion { get; set; }
        public int IdBanco { get; set; }
        public string IdCtaCble { get; set; }
        public string ba_descripcion { get; set; }
        public string dc_Observacion { get; set; }
        public System.DateTime cb_Fecha { get; set; }
        public string nom_IdTipoCbte { get; set; }
        public Nullable<double> dc_Valor { get; set; }
        public Nullable<System.DateTime> fechaConciliacion { get; set; }
        public string IdEstado_Concil_Cat { get; set; }
        public Nullable<bool> Seleccionado { get; set; }
        public int IdTipoCbte { get; set; }
        public decimal IdCbteCble { get; set; }
        public int secuencia { get; set; }
        public string cb_Cheque { get; set; }
        public double co_SaldoBanco_anterior { get; set; }
        public string Tipo { get; set; }
    }
}