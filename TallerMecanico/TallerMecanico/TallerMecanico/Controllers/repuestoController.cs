using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TallerAPI.Models;
using TallerAPI.Data;

namespace TallerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RepuestosController : ControllerBase
    {
        // GET: api/repuestos
        [HttpGet]
        public ActionResult<List<Repuesto>> Get()
        {
            return RepuestoData.Repuestos;
        }

        // GET: api/repuestos/{id}
        [HttpGet("{id}")]
        public ActionResult<Repuesto> Get(int id)
        {
            var repuesto = RepuestoData.Repuestos.FirstOrDefault(r => r.Id == id);
            if (repuesto == null)
                return NotFound();
            return repuesto;
        }

        // POST: api/repuestos
        [HttpPost]
        public ActionResult<Repuesto> Post([FromBody] Repuesto nuevoRepuesto)
        {
            nuevoRepuesto.Id = RepuestoData.Repuestos.Max(r => r.Id) + 1;
            RepuestoData.Repuestos.Add(nuevoRepuesto);
            return CreatedAtAction(nameof(Get), new { id = nuevoRepuesto.Id }, nuevoRepuesto);
        }

        // PUT: api/repuestos/{id}
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Repuesto repuestoActualizado)
        {
            var repuesto = RepuestoData.Repuestos.FirstOrDefault(r => r.Id == id);
            if (repuesto == null)
                return NotFound();

            repuesto.Nombre = repuestoActualizado.Nombre;
            repuesto.Descripcion = repuestoActualizado.Descripcion;
            repuesto.CantidadDisponible = repuestoActualizado.CantidadDisponible;
            repuesto.Precio = repuestoActualizado.Precio;
            repuesto.Activo = repuestoActualizado.Activo;

            return NoContent();
        }

        // DELETE: api/repuestos/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var repuesto = RepuestoData.Repuestos.FirstOrDefault(r => r.Id == id);
            if (repuesto == null)
                return NotFound();

            RepuestoData.Repuestos.Remove(repuesto);
            return NoContent();
        }
    }
}
