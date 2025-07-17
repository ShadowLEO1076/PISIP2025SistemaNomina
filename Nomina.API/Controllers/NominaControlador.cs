using Microsoft.AspNetCore.Mvc;
using NominaPISIB.Aplicacion.DTO.DTOs;
using NominaPISIB.Aplicacion.Servicios;
using NominaPISIB.Infraestructura.AccesoDatos;

namespace Nomina.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NominaControlador : ControllerBase
    {
        private readonly INominasServicio _nominaServicio;

        public NominaControlador(INominasServicio nominaservicio)
        {
            _nominaServicio = nominaservicio;
        }

        [HttpPost("InsertarAutomaticamente")]
        public async Task<IActionResult> InsertarNominaAutomatizado([FromBody] NominasApiDTO request)
        {
            try
            {
                    await _nominaServicio.InsertarNominaAutomatizado(
                    request.name,
                    request.lastname,
                    request.year,
                    request.month
                );
                return Ok();
            }
            catch (Exception ex)
            {
                // Loguear el error si es necesario
                return StatusCode(500, new { error = "Error al insertar la nómina", details = ex.Message });
            }
        }
        // este método es para listar todas las nóminas de los empleados
        [HttpGet("ListarNominasEmpleados")]
        public async Task<IEnumerable<Nominas>> GetAllasync()
        {
            return await _nominaServicio.GetAllAsync();
        }

        // este método obtiene una nómina específica por su ID
        [HttpGet("ObtenerNomina/{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var nomina = await _nominaServicio.GetByIdAsync(id);
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
                await _nominaServicio.AddAsync(nomina);
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
                await _nominaServicio.UpdateAsync(nomina);
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
            var nomina = await _nominaServicio.GetByIdAsync(id);
            if (nomina == null)
            {
                return NotFound($"Nómina con ID {id} no encontrada.");
            }

            try
            {
                await _nominaServicio.DeleteAsync(nomina);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al eliminar la nómina: {ex.Message}");
            }
        }
    }
}
