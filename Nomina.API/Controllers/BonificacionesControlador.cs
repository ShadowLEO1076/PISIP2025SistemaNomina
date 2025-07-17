using Microsoft.AspNetCore.Mvc;
using NominaPISIB.Aplicacion.DTO.DTOs;
using NominaPISIB.Aplicacion.Servicios;
using NominaPISIB.Infraestructura.AccesoDatos;

namespace Nomina.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BonificacionesControlador : ControllerBase
    {
        private readonly IBonificacionesServicio _bonificacionesServicio;

        public BonificacionesControlador(IBonificacionesServicio bonificacionesServicio)
        {
            _bonificacionesServicio = bonificacionesServicio;
        }



        // este método listar las bonificaciones de los empleados
        [HttpGet("ListarEmpleadosBonificaciones")]
        public async Task<IEnumerable<BonificacionesEmpleadoDTO>> ObtenerBonificacionesDeEmpleadoPorAnioYMes(string name, string lastname, int year, int month)
        {
            // aqui va el return adecuado
            return await _bonificacionesServicio.ObtenerBonificacionesDeEmpleadoPorAnioYMes(name, lastname, year, month);

        }

        // este método obtiene un puesto por su ID
        [HttpGet("ObtenerBonificaciones/{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var bonificacion = await _bonificacionesServicio.GetByIdAsync(id);
            if (bonificacion == null)
            {
                return NotFound($"bonificacion con ID {id} no encontrado.");
            }
            return Ok(bonificacion);
        }

        // este método permite agregar un nuevo puesto
        [HttpPost("AgregarBonificacion")] 
        public async Task<IActionResult> AddAsync([FromBody] Bonificaciones bonificacion)
        {
            if (bonificacion == null)
            {
                return BadRequest("La bonificacion no puede ser nulo.");
            }

            try
            {
                await _bonificacionesServicio.AddAsync(bonificacion);
                return CreatedAtAction(nameof(GetByIdAsync), new { id = bonificacion.idBonificaciones }, bonificacion);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al agregar la bonificacion: {ex.Message}");
            }
        }

        // este método permite actualizar un puesto existente
        [HttpPut("ActualizarBonificacion")]
        public async Task<IActionResult> UpdateAsync([FromBody] Bonificaciones bonificacion)
        {
            if (bonificacion == null)
            {
                return BadRequest("La bonificacion no puede ser nulo.");
            }

            try
            {
                await _bonificacionesServicio.UpdateAsync(bonificacion);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al actualizar  la bonificacion: {ex.Message}");
            }
        }

        // este método elimina un puesto por su ID
        [HttpDelete("EliminarPuesto/{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var bonificacion = await _bonificacionesServicio.GetByIdAsync(id);
            if (bonificacion == null)
            {
                return NotFound($"bonificacion con ID {id} no encontrado.");
            }

            try
            {
                await _bonificacionesServicio.DeleteAsync(bonificacion);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al eliminar la bonificacion: {ex.Message}");
            }
        }
    }
}
