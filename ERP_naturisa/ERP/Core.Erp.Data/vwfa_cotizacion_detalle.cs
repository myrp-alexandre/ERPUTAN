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
    
    public partial class vwfa_cotizacion_detalle
    {
        public string bo_Descripcion { get; set; }
        public string Su_Descripcion { get; set; }
        public string Ve_Vendedor { get; set; }
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCotizacion { get; set; }
        public decimal IdCliente { get; set; }
        public int IdVendedor { get; set; }
        public System.DateTime cc_fecha { get; set; }
        public short cc_diasPlazo { get; set; }
        public string cc_observacion { get; set; }
        public string cc_tipopago { get; set; }
        public System.DateTime cc_fechaVencimiento { get; set; }
        public string cc_estado { get; set; }
        public string cc_dirigidoA { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string pe_apellido { get; set; }
        public string pe_nombre { get; set; }
        public int Secuencial { get; set; }
        public decimal IdProducto { get; set; }
        public double dc_cantidad { get; set; }
        public double dc_precio { get; set; }
        public double dc_por_desUni { get; set; }
        public double dc_desUni { get; set; }
        public double dc_precioFinal { get; set; }
        public double dc_subtotal { get; set; }
        public double dc_iva { get; set; }
        public double dc_total { get; set; }
        public string dc_pagaIva { get; set; }
        public string dc_detallexItems { get; set; }
        public string CodCotizacion { get; set; }
    }
}
