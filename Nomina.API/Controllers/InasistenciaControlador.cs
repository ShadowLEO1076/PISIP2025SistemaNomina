using Microsoft.AspNetCore.Mvc;
using NominaPISIB.Aplicacion.Servicios;
using NominaPISIB.Infraestructura.AccesoDatos;

namespace Nomina.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InasistenciaControlador : ControllerBase
    {
        private readonly IInasistenciasServicio _inasistenciaServicio;

        public InasistenciaControlador(IInasistenciasServicio inasistenciaServicio)
        {
            _inasistenciaServicio = inasistenciaServicio;
        }

        // Listar todas las inasistencias
        [HttpGet("Listar Inasistencias")]
        public Task<IEnumerable<Inasistencias>> GetAllasync()
        {
            return _inasistenciaServicio.GetAllAsync();
        }

        // Obtener inasistencia por ID
        [HttpGet("Obtener Inasistencia/{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var inasistencia = await _inasistenciaServicio.GetByIdAsync(id);
            if (inasistencia == null)
            {
                return NotFound($"Inasistencia con ID {id} no encontrada.");
            }
            return Ok(inasistencia);
        }

        // Agregar una nueva inasistencia
        [HttpPost("Agregar Inasistencia")]
        public async Task<IActionResult> AddAsync([FromBody] Inasistencias inasistencia)
        {
            if (inasistencia == null)
            {
                return BadRequest("La inasistencia no puede ser nula.");
            }

            try
            {
                await _inasistenciaServicio.AddAsync(inasistencia);
                return CreatedAtAction(nameof(GetByIdAsync), new { id = inasistencia.idEmpleado }, inasistencia);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al agregar la inasistencia: {ex.Message}");
            }
        }

        // Actualizar una inasistencia
        [HttpPut("Actualizar Inasistencia")]
        public async Task<IActionResult> UpdateAsync([FromBody] Inasistencias inasistencia)
        {
            if (inasistencia == null)
            {
                return BadRequest("La inasistencia no puede ser nula.");
            }

            try
            {
                await _inasistenciaServicio.UpdateAsync(inasistencia);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al actualizar la inasistencia: {ex.Message}");
            }
        }

        // Eliminar una inasistencia por ID
        [HttpDelete("Eliminar Inasistencia/{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var inasistencia = await _inasistenciaServicio.GetByIdAsync(id);
            if (inasistencia == null)
            {
                return NotFound($"Inasistencia con ID {id} no encontrada.");
            }

            try
            {
                await _inasistenciaServicio.DeleteAsync(inasistencia);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al eliminar la inasistencia: {ex.Message}");
            }
        }
    }
}
