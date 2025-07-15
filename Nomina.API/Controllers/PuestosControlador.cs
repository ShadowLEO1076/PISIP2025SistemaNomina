using Microsoft.AspNetCore.Mvc;
using NominaPISIB.Aplicacion.Servicios;
using NominaPISIB.Infraestructura.AccesoDatos;

namespace Nomina.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PuestosControlador : ControllerBase
    {
        private readonly IPuestosServicio _puestosServicio;

        public PuestosControlador(IPuestosServicio puestosServicio)
        {
            _puestosServicio = puestosServicio;
        }

        // este método lista todos los puestos disponibles
        [HttpGet("Listar Empleados Puestos")]
        public Task<IEnumerable<Puestos>> GetAllasync()
        {
            return _puestosServicio.GetAllAsync();
        }

        // este método obtiene un puesto por su ID
        [HttpGet("Obtener Puesto/{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var puesto = await _puestosServicio.GetByIdAsync(id);
            if (puesto == null)
            {
                return NotFound($"Puesto con ID {id} no encontrado.");
            }
            return Ok(puesto);
        }

        // este método permite agregar un nuevo puesto
        [HttpPost("Agregar Puesto")]
        public async Task<IActionResult> AddAsync([FromBody] Puestos puesto)
        {
            if (puesto == null)
            {
                return BadRequest("El puesto no puede ser nulo.");
            }

            try
            {
                await _puestosServicio.AddAsync(puesto);
                return CreatedAtAction(nameof(GetByIdAsync), new { id = puesto.idPuesto }, puesto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al agregar el puesto: {ex.Message}");
            }
        }

        // este método permite actualizar un puesto existente
        [HttpPut("Actualizar Puesto")]
        public async Task<IActionResult> UpdateAsync([FromBody] Puestos puesto)
        {
            if (puesto == null)
            {
                return BadRequest("El puesto no puede ser nulo.");
            }

            try
            {
                await _puestosServicio.UpdateAsync(puesto);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al actualizar el puesto: {ex.Message}");
            }
        }

        // este método elimina un puesto por su ID
        [HttpDelete("Eliminar Puesto/{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var puesto = await _puestosServicio.GetByIdAsync(id);
            if (puesto == null)
            {
                return NotFound($"Puesto con ID {id} no encontrado.");
            }

            try
            {
                await _puestosServicio.DeleteAsync(puesto);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al eliminar el puesto: {ex.Message}");
            }
        }
    }
}
