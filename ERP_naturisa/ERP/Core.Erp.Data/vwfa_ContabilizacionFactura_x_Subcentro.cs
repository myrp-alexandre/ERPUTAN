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
    using System.Collections.Generic;
    
    public partial class vwfa_ContabilizacionFactura_x_Subcentro
    {
        public long IdFila { get; set; }
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCbteVta { get; set; }
        public Nullable<double> Subtotal { get; set; }
        public Nullable<double> Descuento { get; set; }
        public Nullable<double> iva { get; set; }
        public Nullable<double> Total { get; set; }
        public string IdCtaCble_Ven0 { get; set; }
        public string IdCtaCble_VenIva { get; set; }
        public string vt_tipo_venta { get; set; }
        public decimal vt_plazo { get; set; }
        public Nullable<int> IdCtaCble_DesIva { get; set; }
        public Nullable<int> IdCtaCble_Des0 { get; set; }
        public int Secuencia { get; set; }
        public string IdCod_Impuesto_Iva { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string IdCtaCble_Imp_Iva { get; set; }
    }
}
