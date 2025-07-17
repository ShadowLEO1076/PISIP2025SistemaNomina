using System.Diagnostics.Contracts;
using Microsoft.AspNetCore.Mvc;
using NominaPISIB.Aplicacion.Servicios;
using NominaPISIB.Infraestructura.AccesoDatos;

namespace Nomina.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContratosControlador : ControllerBase
    {
        private readonly IContratosServicio _contratosServicio;

        public ContratosControlador(IContratosServicio contratosServicio)
        {
            _contratosServicio = contratosServicio;
        }

        // este método lista todos los contratos disponibles
        [HttpGet("ListarEmpleadosContratos")]
        public Task<IEnumerable<Contratos>> GetAllasync()
        {
            return _contratosServicio.GetAllAsync();
        }

        // este método obtiene un puesto por su ID
        [HttpGet("ObtenerContrato/{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var contrato = await _contratosServicio.GetByIdAsync(id);
            if (contrato == null)
            {
                return NotFound($"contrato con ID {id} no encontrado.");
            }
            return Ok(contrato);
        }

        // este método permite agregar un nuevo puesto
        [HttpPost("AgregarContrato")]
        public async Task<IActionResult> AddAsync([FromBody] Contratos contrato)
        {
            if (contrato == null)
            {
                return BadRequest("El contrato no puede ser nulo.");
            }

            try
            {
                await _contratosServicio.AddAsync(contrato);
                return CreatedAtAction(nameof(GetByIdAsync), new { id = contrato.idContrato }, contrato);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al agregar el contrato: {ex.Message}");
            }
        }

        // este método permite actualizar un puesto existente
        [HttpPut("ActualizarContrato")]
        public async Task<IActionResult> UpdateAsync([FromBody] Contratos contrato)
        {
            if (contrato == null)
            {
                return BadRequest("El contrato no puede ser nulo.");
            }

            try
            {
                await _contratosServicio.UpdateAsync(contrato);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al actualizar el contrato: {ex.Message}");
            }
        }

        // este método elimina un puesto por su ID
        [HttpDelete("EliminarPuesto/{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var contrato = await _contratosServicio.GetByIdAsync(id);
            if (contrato == null)
            {
                return NotFound($"Puesto con ID {id} no encontrado.");
            }

            try
            {
                await _contratosServicio.DeleteAsync(contrato);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al eliminar el contrato: {ex.Message}");
            }
        }
    }
}
