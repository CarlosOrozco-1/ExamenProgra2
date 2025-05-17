using System;
using System.Collections.Generic;

namespace TallerAPI.Models
{
    public class Factura
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }           // Cliente al que se le emite la factura
        public DateTime Fecha { get; set; }          // Fecha de emisión
        public decimal Total { get; set; }           // Monto total de la factura
        public List<DetalleFactura> Detalles { get; set; }  // Detalles de la factura (servicios, repuestos)
    }

    public class DetalleFactura
    {
        public int Id { get; set; }
        public int FacturaId { get; set; }
        public string Descripcion { get; set; }      // Descripción del servicio o repuesto
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }
    }
}
