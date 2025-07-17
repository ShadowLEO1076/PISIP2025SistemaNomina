using Microsoft.AspNetCore.Mvc;
using NominaPISIB.Aplicacion.Servicios;
using NominaPISIB.Infraestructura.AccesoDatos;

namespace Nomina.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LicenciaControlador : ControllerBase
    {
        private readonly ILicenciasServicio _licenciasServicio;

        public LicenciaControlador(ILicenciasServicio licenciasServicio)
        {
            _licenciasServicio = licenciasServicio;
        }

        // Listar todas las licencias
        [HttpGet("ListarLicencias")]
        public Task<IEnumerable<Licencias>> GetAllasync()
        {
            return _licenciasServicio.GetAllAsync();
        }

        // Obtener una licencia por ID
        [HttpGet("ObtenerLicencia/{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var licencia = await _licenciasServicio.GetByIdAsync(id);
            if (licencia == null)
            {
                return NotFound($"Licencia con ID {id} no encontrada.");
            }
            return Ok(licencia);
        }

        // Agregar nueva licencia
        [HttpPost("AgregarLicencia")]
        public async Task<IActionResult> AddAsync([FromBody] Licencias licencia)
        {
            if (licencia == null)
            {
                return BadRequest("La licencia no puede ser nula.");
            }

            try
            {
                await _licenciasServicio.AddAsync(licencia);
                return CreatedAtAction(nameof(GetByIdAsync), new { id = licencia.idLicencia }, licencia);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al agregar la licencia: {ex.Message}");
            }
        }

        // Actualizar licencia existente
        [HttpPut("ActualizarLicencia")]
        public async Task<IActionResult> UpdateAsync([FromBody] Licencias licencia)
        {
            if (licencia == null)
            {
                return BadRequest("La licencia no puede ser nula.");
            }

            try
            {
                await _licenciasServicio.UpdateAsync(licencia);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al actualizar la licencia: {ex.Message}");
            }
        }

        // Eliminar licencia por ID
        [HttpDelete("EliminarLicencia/{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var licencia = await _licenciasServicio.GetByIdAsync(id);
            if (licencia == null)
            {
                return NotFound($"Licencia con ID {id} no encontrada.");
            }

            try
            {
                await _licenciasServicio.DeleteAsync(licencia);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al eliminar la licencia: {ex.Message}");
            }
        }
    }
}
