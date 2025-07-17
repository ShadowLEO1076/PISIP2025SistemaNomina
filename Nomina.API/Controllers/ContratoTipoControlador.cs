using System.Diagnostics.Contracts;
using Microsoft.AspNetCore.Mvc;
using NominaPISIB.Aplicacion.Servicios;
using NominaPISIB.Infraestructura.AccesoDatos;

namespace Nomina.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContratosTipoControlador : ControllerBase
    {
        private readonly IContratosTipoServicio _contratostipoServicio;

        public ContratosTipoControlador(IContratosTipoServicio contratostipoServicio)
        {
            _contratostipoServicio = contratostipoServicio;
        }

        // este método lista todos los contratos disponibles
        [HttpGet("ListarEmpleadosContratosTipo")]
        public Task<IEnumerable<ContratosTipo>> GetAllasync()
        {
            return _contratostipoServicio.GetAllAsync();
        }

        // este método obtiene un puesto por su ID
        [HttpGet("ObtenerContratoTipo/{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var contratotipo = await _contratostipoServicio.GetByIdAsync(id);
            if (contratotipo == null)
            {
                return NotFound($"contrato tipo con ID {id} no encontrado.");
            }
            return Ok(contratotipo);
        }

        // este método permite agregar un nuevo puesto
        [HttpPost("AgregarContratoTipo")]
        public async Task<IActionResult> AddAsync([FromBody] ContratosTipo contratotipo)
        {
            if (contratotipo == null)
            {
                return BadRequest("El contrato tipo no puede ser nulo.");
            }

            try
            {
                await _contratostipoServicio.AddAsync(contratotipo);
                return CreatedAtAction(nameof(GetByIdAsync), new { id = contratotipo.idContratoTipo }, contratotipo);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al agregar el contrato tipo: {ex.Message}");
            }
        }

        // este método permite actualizar un puesto existente
        [HttpPut("ActualizarContratoTipo")]
        public async Task<IActionResult> UpdateAsync([FromBody] ContratosTipo contratotipo)
        {
            if (contratotipo == null)
            {
                return BadRequest("El contrato tipo no puede ser nulo.");
            }

            try
            {
                await _contratostipoServicio.UpdateAsync(contratotipo);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al actualizar el contrato tipo: {ex.Message}");
            }
        }

        // este método elimina un puesto por su ID
        [HttpDelete("EliminarContratoTipo/{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var contratotipo = await _contratostipoServicio.GetByIdAsync(id);
            if (contratotipo == null)
            {
                return NotFound($"contrato tipo con ID {id} no encontrado.");
            }

            try
            {
                await _contratostipoServicio.DeleteAsync(contratotipo);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al eliminar el contrato tipo: {ex.Message}");
            }
        }
    }
}
