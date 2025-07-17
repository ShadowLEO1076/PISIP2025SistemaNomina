using Microsoft.AspNetCore.Mvc;
using NominaPISIB.Aplicacion.Servicios;
using NominaPISIB.Infraestructura.AccesoDatos;

namespace Nomina.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class SolicitudVacacionesControlador : ControllerBase
    {
        private ISolicitudVacacionesServicio _solicitudvacaciones;

        public SolicitudVacacionesControlador(ISolicitudVacacionesServicio solicitudvacaciones)
        {
            _solicitudvacaciones = solicitudvacaciones;
        }

        [HttpGet("ListarEmpleadosVacaciones")]

        // este metodo es para listar las solicitudes de vacaciones
        public Task<IEnumerable<SolicitudVacaciones>> GetAllasync()
        {
            return _solicitudvacaciones.GetAllAsync();
            //return _empleadosVacacionesTotalesServicio.GetAllAsync();
            // creo que no me funciona tarea porque no tengo el servicio implementado
            // para solucionarlo seguir los siguientes pasos:
            // 1. Asegurarse de que el servicio IEmpleadosVacacionesTotalesServicio esté implementado correctamente.
            // lo solucione comentar con IA ES LO MEJOR :3

        }
        // voy a crear un metodo para agregar una solicitud de vacaciones
        [HttpPost("AgregarSolicitudVacaciones")]
        public async Task<IActionResult> AddAsync([FromBody] SolicitudVacaciones solicitudVacaciones)
        {
            if (solicitudVacaciones == null)
            {
                return BadRequest("La solicitud de vacaciones no puede ser nula.");
            }
            try
            {
                await _solicitudvacaciones.AddAsync(solicitudVacaciones);
                //return CreatedAtAction(nameof(GetAllasync), new { id = solicitudVacaciones.Id }, solicitudVacaciones);
                // "SolicitudVacaciones" no contiene una definición para "Id" ni un método de extensión accesible "Id" que acepte un primer argumento del tipo "SolicitudVacaciones" (¿falta alguna directiva using o una referencia de ensamblado?)
                // por lo tanto sera asi 
                return CreatedAtAction(nameof(GetAllasync), new { id = solicitudVacaciones.idSolicitudVacacion }, solicitudVacaciones);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al agregar la solicitud de vacaciones: {ex.Message}");
            }

        }
        // voy a crear un metodo para eliminar una solicitud de vacaciones
        [HttpDelete("EliminarSolicitudVacaciones/{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var solicitudVacaciones = await _solicitudvacaciones.GetByIdAsync(id);
            if (solicitudVacaciones == null)
            {
                return NotFound($"Solicitud de vacaciones con ID {id} no encontrada.");
            }
            try
            {
                await _solicitudvacaciones.DeleteAsync(solicitudVacaciones);
                return NoContent(); // 204 No Content
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al eliminar la solicitud de vacaciones: {ex.Message}");
            }
        }
        // voy a crear un metodo para actualizar una solicitud de vacaciones
        [HttpPut("ActualizarSolicitudVacaciones")]
        public async Task<IActionResult> UpdateAsync([FromBody] SolicitudVacaciones solicitudVacaciones)
        {
            if (solicitudVacaciones == null)
            {
                return BadRequest("La solicitud de vacaciones no puede ser nula.");
            }
            try
            {
                await _solicitudvacaciones.UpdateAsync(solicitudVacaciones);
                return NoContent(); // 204 No Content
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al actualizar la solicitud de vacaciones: {ex.Message}");
            }
        }
    }
}


