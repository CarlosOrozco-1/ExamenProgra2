using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TallerAPI.Models;
using TallerAPI.Data;

namespace TallerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MecanicosController : ControllerBase
    {
        // GET: api/mecanicos
        [HttpGet]
        public ActionResult<List<Mecanico>> Get()
        {
            return MecanicoData.Mecanicos;
        }

        // GET: api/mecanicos/{id}
        [HttpGet("{id}")]
        public ActionResult<Mecanico> Get(int id)
        {
            var mecanico = MecanicoData.Mecanicos.FirstOrDefault(m => m.Id == id);
            if (mecanico == null)
                return NotFound();
            return mecanico;
        }

        // POST: api/mecanicos
        [HttpPost]
        public ActionResult<Mecanico> Post([FromBody] Mecanico nuevoMecanico)
        {
            nuevoMecanico.Id = MecanicoData.Mecanicos.Max(m => m.Id) + 1;
            MecanicoData.Mecanicos.Add(nuevoMecanico);
            return CreatedAtAction(nameof(Get), new { id = nuevoMecanico.Id }, nuevoMecanico);
        }

        // PUT: api/mecanicos/{id}
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Mecanico mecanicoActualizado)
        {
            var mecanico = MecanicoData.Mecanicos.FirstOrDefault(m => m.Id == id);
            if (mecanico == null)
                return NotFound();

            mecanico.Nombre = mecanicoActualizado.Nombre;
            mecanico.Especialidad = mecanicoActualizado.Especialidad;
            mecanico.Telefono = mecanicoActualizado.Telefono;
            mecanico.Email = mecanicoActualizado.Email;
            mecanico.Activo = mecanicoActualizado.Activo;

            return NoContent();
        }

        // DELETE: api/mecanicos/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var mecanico = MecanicoData.Mecanicos.FirstOrDefault(m => m.Id == id);
            if (mecanico == null)
                return NotFound();

            MecanicoData.Mecanicos.Remove(mecanico);
            return NoContent();
        }
    }
}
