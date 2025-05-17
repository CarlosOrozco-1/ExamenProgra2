using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TallerAPI.Models;
using TallerAPI.Data;

namespace TallerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        // GET: api/clientes
        [HttpGet]
        public ActionResult<List<Cliente>> Get()
        {
            return ClienteData.Clientes;
        }

        // GET: api/clientes/{id}
        [HttpGet("{id}")]
        public ActionResult<Cliente> Get(int id)
        {
            var cliente = ClienteData.Clientes.FirstOrDefault(c => c.Id == id);
            if (cliente == null)
                return NotFound();
            return cliente;
        }

        // POST: api/clientes
        [HttpPost]
        public ActionResult<Cliente> Post([FromBody] Cliente nuevoCliente)
        {
            nuevoCliente.Id = ClienteData.Clientes.Max(c => c.Id) + 1;
            ClienteData.Clientes.Add(nuevoCliente);
            return CreatedAtAction(nameof(Get), new { id = nuevoCliente.Id }, nuevoCliente);
        }

        // PUT: api/clientes/{id}
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Cliente clienteActualizado)
        {
            var cliente = ClienteData.Clientes.FirstOrDefault(c => c.Id == id);
            if (cliente == null)
                return NotFound();

            cliente.Nombre = clienteActualizado.Nombre;
            cliente.Telefono = clienteActualizado.Telefono;
            cliente.Email = clienteActualizado.Email;
            cliente.Direccion = clienteActualizado.Direccion;
            cliente.Ciudad = clienteActualizado.Ciudad;
            cliente.CodigoPostal = clienteActualizado.CodigoPostal;
            cliente.Activo = clienteActualizado.Activo;

            return NoContent();
        }

        // DELETE: api/clientes/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var cliente = ClienteData.Clientes.FirstOrDefault(c => c.Id == id);
            if (cliente == null)
                return NotFound();

            ClienteData.Clientes.Remove(cliente);
            return NoContent();
        }
    }
}
