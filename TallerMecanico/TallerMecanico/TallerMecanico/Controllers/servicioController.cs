using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TallerAPI.Models;
using TallerAPI.Data;

namespace TallerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServiciosController : ControllerBase
    {
        // GET: api/servicios
        [HttpGet]
        public ActionResult<List<Servicio>> Get()
        {
            return ServicioData.Servicios;
        }

        // GET: api/servicios/{id}
        [HttpGet("{id}")]
        public ActionResult<Servicio> Get(int id)
        {
            var servicio = ServicioData.Servicios.FirstOrDefault(s => s.Id == id);
            if (servicio == null)
                return NotFound();
            return servicio;
        }

        // POST: api/servicios
        [HttpPost]
        public ActionResult<Servicio> Post([FromBody] Servicio nuevoServicio)
        {
            nuevoServicio.Id = ServicioData.Servicios.Max(s => s.Id) + 1;
            ServicioData.Servicios.Add(nuevoServicio);
            return CreatedAtAction(nameof(Get), new { id = nuevoServicio.Id }, nuevoServicio);
        }

        // PUT: api/servicios/{id}
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Servicio servicioActualizado)
        {
            var servicio = ServicioData.Servicios.FirstOrDefault(s => s.Id == id);
            if (servicio == null)
                return NotFound();

            servicio.Nombre = servicioActualizado.Nombre;
            servicio.Descripcion = servicioActualizado.Descripcion;
            servicio.Precio = servicioActualizado.Precio;
            servicio.Activo = servicioActualizado.Activo;

            return NoContent();
        }

        // DELETE: api/servicios/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var servicio = ServicioData.Servicios.FirstOrDefault(s => s.Id == id);
            if (servicio == null)
                return NotFound();

            ServicioData.Servicios.Remove(servicio);
            return NoContent();
        }
    }
}
