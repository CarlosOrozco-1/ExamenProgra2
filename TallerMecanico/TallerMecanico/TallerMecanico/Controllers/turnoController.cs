using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TallerAPI.Models;
using TallerAPI.Data;

namespace TallerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TurnosController : ControllerBase
    {
        // GET: api/turnos
        [HttpGet]
        public ActionResult<List<Turno>> Get()
        {
            return TurnoData.Turnos;
        }

        // GET: api/turnos/{id}
        [HttpGet("{id}")]
        public ActionResult<Turno> Get(int id)
        {
            var turno = TurnoData.Turnos.FirstOrDefault(t => t.Id == id);
            if (turno == null)
                return NotFound();
            return turno;
        }

        // POST: api/turnos
        [HttpPost]
        public ActionResult<Turno> Post([FromBody] Turno nuevoTurno)
        {
            nuevoTurno.Id = TurnoData.Turnos.Max(t => t.Id) + 1;
            TurnoData.Turnos.Add(nuevoTurno);
            return CreatedAtAction(nameof(Get), new { id = nuevoTurno.Id }, nuevoTurno);
        }

        // PUT: api/turnos/{id}
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Turno turnoActualizado)
        {
            var turno = TurnoData.Turnos.FirstOrDefault(t => t.Id == id);
            if (turno == null)
                return NotFound();

            turno.ClienteId = turnoActualizado.ClienteId;
            turno.VehiculoId = turnoActualizado.VehiculoId;
            turno.MecanicoId = turnoActualizado.MecanicoId;
            turno.FechaHora = turnoActualizado.FechaHora;
            turno.Estado = turnoActualizado.Estado;
            turno.Observaciones = turnoActualizado.Observaciones;

            return NoContent();
        }

        // DELETE: api/turnos/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var turno = TurnoData.Turnos.FirstOrDefault(t => t.Id == id);
            if (turno == null)
                return NotFound();

            TurnoData.Turnos.Remove(turno);
            return NoContent();
        }
    }
}
