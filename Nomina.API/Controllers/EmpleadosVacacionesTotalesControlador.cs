using Microsoft.AspNetCore.Mvc;
using NominaPISIB.Aplicacion.Servicios;
using NominaPISIB.Infraestructura.AccesoDatos;

namespace Nomina.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmpleadosVacacionesTotalesControlador : ControllerBase
    {
        private readonly IEmpleadosVacacionesTotalesServicio _empleadosVacacionesTotalesServicio;

        public EmpleadosVacacionesTotalesControlador(IEmpleadosVacacionesTotalesServicio empleadosVacacionesTotalesServicio)
        {
            _empleadosVacacionesTotalesServicio = empleadosVacacionesTotalesServicio;
        }

        // Listar todos los registros
        [HttpGet("ListarEmpleadosVacaciones")]
        public Task<IEnumerable<EmpleadosVacacionesTotales>> GetAllasync()
        {
            return _empleadosVacacionesTotalesServicio.GetAllAsync();
        }

        // Obtener vacaciones totales por ID
        [HttpGet("ObtenerVacacionesEmpleado/{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var vacaciones = await _empleadosVacacionesTotalesServicio.GetByIdAsync(id);
            if (vacaciones == null)
            {
                return NotFound($"Registro de vacaciones con ID {id} no encontrado.");
            }
            return Ok(vacaciones);
        }

        // Agregar nuevo registro
        [HttpPost("AgregarVacacionesEmpleado")]
        public async Task<IActionResult> AddAsync([FromBody] EmpleadosVacacionesTotales vacacionesTotales)
        {
            if (vacacionesTotales == null)
            {
                return BadRequest("El registro de vacaciones no puede ser nulo.");
            }

            try
            {
                await _empleadosVacacionesTotalesServicio.AddAsync(vacacionesTotales);
                return CreatedAtAction(nameof(GetByIdAsync), new { id = vacacionesTotales.idEmpleado }, vacacionesTotales);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al agregar el registro: {ex.Message}");
            }
        }

        // Actualizar registro
        [HttpPut("ActualizarVacacionesEmpleado")]
        public async Task<IActionResult> UpdateAsync([FromBody] EmpleadosVacacionesTotales vacacionesTotales)
        {
            if (vacacionesTotales == null)
            {
                return BadRequest("El registro de vacaciones no puede ser nulo.");
            }

            try
            {
                await _empleadosVacacionesTotalesServicio.UpdateAsync(vacacionesTotales);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al actualizar el registro: {ex.Message}");
            }
        }

        // Eliminar registro por ID
        [HttpDelete("EliminarVacacionesEmpleado/{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var vacaciones = await _empleadosVacacionesTotalesServicio.GetByIdAsync(id);
            if (vacaciones == null)
            {
                return NotFound($"Registro de vacaciones con ID {id} no encontrado.");
            }

            try
            {
                await _empleadosVacacionesTotalesServicio.DeleteAsync(vacaciones);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al eliminar el registro: {ex.Message}");
            }
        }
    }
}
