using Microsoft.AspNetCore.Mvc;
using NominaPISIB.Aplicacion.Servicios;
using NominaPISIB.Infraestructura.AccesoDatos;

namespace Nomina.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NominaControlador : ControllerBase
    {
        private readonly INominasServicio _nominaservicio;

        public NominaControlador(INominasServicio nominaservicio)
        {
            _nominaservicio = nominaservicio;
        }

        // este método es para listar todas las nóminas de los empleados
        [HttpGet("ListarNominasEmpleados")]
        public Task<IEnumerable<Nominas>> GetAllasync()
        {
            return _nominaservicio.GetAllAsync();
        }

        // este método obtiene una nómina específica por su ID
        [HttpGet("ObtenerNomina/{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var nomina = await _nominaservicio.GetByIdAsync(id);
            if (nomina == null)
            {
                return NotFound($"Nómina con ID {id} no encontrada.");
            }
            return Ok(nomina);
        }

        // este método permite agregar una nueva nómina
        [HttpPost("AgregarNomina")]
        public async Task<IActionResult> AddAsync([FromBody] Nominas nomina)
        {
            if (nomina == null)
            {
                return BadRequest("La nómina no puede ser nula.");
            }

            try
            {
                await _nominaservicio.AddAsync(nomina);
                return CreatedAtAction(nameof(GetByIdAsync), new { id = nomina.idNomina }, nomina);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al agregar la nómina: {ex.Message}");
            }
        }

        // este método permite actualizar una nómina existente
        [HttpPut("ActualizarNomina")]
        public async Task<IActionResult> UpdateAsync([FromBody] Nominas nomina)
        {
            if (nomina == null)
            {
                return BadRequest("La nómina no puede ser nula.");
            }

            try
            {
                await _nominaservicio.UpdateAsync(nomina);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al actualizar la nómina: {ex.Message}");
            }
        }

        // este método elimina una nómina específica por su ID
        [HttpDelete("EliminarNomina/{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var nomina = await _nominaservicio.GetByIdAsync(id);
            if (nomina == null)
            {
                return NotFound($"Nómina con ID {id} no encontrada.");
            }

            try
            {
                await _nominaservicio.DeleteAsync(nomina);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al eliminar la nómina: {ex.Message}");
            }
        }
    }
}
