using System;
using System.Collections.Generic;
using TallerAPI.Models;

namespace TallerAPI.Data
{
    public static class FacturaData
    {
        public static List<Factura> Facturas = new List<Factura>()
        {
            new Factura
            {
                Id = 1,
                ClienteId = 1,
                Fecha = DateTime.Now.AddDays(-10),
                Total = 1200.00m,
                Detalles = new List<DetalleFactura>
                {
                    new DetalleFactura { Id = 1, FacturaId = 1, Descripcion = "Cambio de aceite", Cantidad = 1, PrecioUnitario = 500.00m, Subtotal = 500.00m },
                    new DetalleFactura { Id = 2, FacturaId = 1, Descripcion = "Filtro de aceite", Cantidad = 1, PrecioUnitario = 250.00m, Subtotal = 250.00m },
                    new DetalleFactura { Id = 3, FacturaId = 1, Descripcion = "Mano de obra", Cantidad = 1, PrecioUnitario = 450.00m, Subtotal = 450.00m }
                }
            },
            new Factura
            {
                Id = 2,
                ClienteId = 2,
                Fecha = DateTime.Now.AddDays(-5),
                Total = 800.00m,
                Detalles = new List<DetalleFactura>
                {
                    new DetalleFactura { Id = 4, FacturaId = 2, Descripcion = "Revisión frenos", Cantidad = 1, PrecioUnitario = 300.00m, Subtotal = 300.00m },
                    new DetalleFactura { Id = 5, FacturaId = 2, Descripcion = "Pastillas de freno", Cantidad = 1, PrecioUnitario = 500.00m, Subtotal = 500.00m }
                }
            },
            new Factura
            {
                Id = 3,
                ClienteId = 3,
                Fecha = DateTime.Now.AddDays(-3),
                Total = 1500.00m,
                Detalles = new List<DetalleFactura>
                {
                    new DetalleFactura { Id = 6, FacturaId = 3, Descripcion = "Correa de distribución", Cantidad = 1, PrecioUnitario = 800.00m, Subtotal = 800.00m },
                    new DetalleFactura { Id = 7, FacturaId = 3, Descripcion = "Mano de obra", Cantidad = 1, PrecioUnitario = 700.00m, Subtotal = 700.00m }
                }
            },
            new Factura
            {
                Id = 4,
                ClienteId = 4,
                Fecha = DateTime.Now.AddDays(-1),
                Total = 350.00m,
                Detalles = new List<DetalleFactura>
                {
                    new DetalleFactura { Id = 8, FacturaId = 4, Descripcion = "Aceite motor 5W-30", Cantidad = 1, PrecioUnitario = 350.00m, Subtotal = 350.00m }
                }
            },
            new Factura
            {
                Id = 5,
                ClienteId = 5,
                Fecha = DateTime.Now,
                Total = 1000.00m,
                Detalles = new List<DetalleFactura>
                {
                    new DetalleFactura { Id = 9, FacturaId = 5, Descripcion = "Alineación", Cantidad = 1, PrecioUnitario = 1000.00m, Subtotal = 1000.00m }
                }
            }
        };
    }
}
