using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TallerAPI.Models;
using TallerAPI.Data;

namespace TallerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FacturasController : ControllerBase
    {
        // GET: api/facturas
        [HttpGet]
        public ActionResult<List<Factura>> Get()
        {
            return FacturaData.Facturas;
        }

        // GET: api/facturas/{id}
        [HttpGet("{id}")]
        public ActionResult<Factura> Get(int id)
        {
            var factura = FacturaData.Facturas.FirstOrDefault(f => f.Id == id);
            if (factura == null)
                return NotFound();
            return factura;
        }

        // POST: api/facturas
        [HttpPost]
        public ActionResult<Factura> Post([FromBody] Factura nuevaFactura)
        {
            nuevaFactura.Id = FacturaData.Facturas.Max(f => f.Id) + 1;
            if (nuevaFactura.Detalles != null)
            {
                int maxDetalleId = FacturaData.Facturas.SelectMany(f => f.Detalles).Any()
                    ? FacturaData.Facturas.SelectMany(f => f.Detalles).Max(d => d.Id)
                    : 0;

                foreach (var detalle in nuevaFactura.Detalles)
                {
                    detalle.Id = ++maxDetalleId;
                    detalle.FacturaId = nuevaFactura.Id;
                }
            }
            FacturaData.Facturas.Add(nuevaFactura);
            return CreatedAtAction(nameof(Get), new { id = nuevaFactura.Id }, nuevaFactura);
        }

        // PUT: api/facturas/{id}
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Factura facturaActualizada)
        {
            var factura = FacturaData.Facturas.FirstOrDefault(f => f.Id == id);
            if (factura == null)
                return NotFound();

            factura.ClienteId = facturaActualizada.ClienteId;
            factura.Fecha = facturaActualizada.Fecha;
            factura.Total = facturaActualizada.Total;
            factura.Detalles = facturaActualizada.Detalles;

            return NoContent();
        }

        // DELETE: api/facturas/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var factura = FacturaData.Facturas.FirstOrDefault(f => f.Id == id);
            if (factura == null)
                return NotFound();

            FacturaData.Facturas.Remove(factura);
            return NoContent();
        }
    }
}
