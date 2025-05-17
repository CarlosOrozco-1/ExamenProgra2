using Microsoft.AspNetCore.Mvc;
using TallerMecanicoAPI.Data;
using TallerMecanicoAPI.Models;

namespace TallerMecanicoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehiculoController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Vehiculo>> Get()
        {
            return Ok(VehiculoRepository.GetVehiculos());
        }

        [HttpGet("{id}")]
        public ActionResult<Vehiculo> Get(int id)
        {
            var vehiculo = VehiculoRepository.GetVehiculoById(id);
            if (vehiculo == null) return NotFound();
            return Ok(vehiculo);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Vehiculo vehiculo)
        {
            VehiculoRepository.AddVehiculo(vehiculo);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            VehiculoRepository.DeleteVehiculo(id);
            return NoContent();
        }
    }
}
