using Microsoft.AspNetCore.Mvc;
using NominaPISIB.Aplicacion.Servicios;
using NominaPISIB.Infraestructura.AccesoDatos;

namespace Nomina.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AprobacionVacacionesControlador :ControllerBase
    {
        private readonly IAprobacionVacacionesServicio _servicio;

        public AprobacionVacacionesControlador (IAprobacionVacacionesServicio servicio)
        {
            _servicio = servicio;
        }

        [HttpGet("ListarAprobacionVacaciones")]
        public Task<IEnumerable<AprobacionVacaciones>> GetAllasync()
        {
            return _servicio.GetAllAsync();
        }

        [HttpGet("/{id}")] //-> Si ponemos un prefijo como AprobacionVacaciones/{id} no funciona
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var aprobVac = await _servicio.GetByIdAsync(id);
            
            if(aprobVac == null)
            {
                Console.WriteLine($"Error : no se halló el dato");
                return StatusCode(500, "Error interno");
            }

            return Ok(aprobVac);
        }

        [HttpPost("InsertarAprobaciónVacaciones")]
        public async Task<IActionResult> AddAsync([FromBody] AprobacionVacaciones aprobacionVacaciones) 
        {
        if (aprobacionVacaciones == null)
            {
                BadRequest("La entidad no puede estar vacia");
            }

            try
            {
                await _servicio.AddAsync(aprobacionVacaciones);
                return Ok();
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Error : {ex.Message}");
                return StatusCode(500, "Error interno");
            }
        }

        [HttpPut("ActualizarAprobaciónVacaciones")]
        public async Task<IActionResult> UpdateAsync([FromBody] AprobacionVacaciones aprobacionVacaciones) 
        {
            if (aprobacionVacaciones == null)
            {
                BadRequest("La entidad no puede estar vacia");
            }


            try
            {
                await _servicio.UpdateAsync(aprobacionVacaciones);
                return Ok();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
                return StatusCode(500, "Error interno");
            }
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteAsyn(int id) 
        {
            var aprobVac = await _servicio.GetByIdAsync(id);

            if (aprobVac == null)
            {
                BadRequest("La entidad no puede estar vacia");
            }

            try
            {
                await _servicio.DeleteAsync(aprobVac);
                return Ok();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
                return StatusCode(500, "Error interno");
            }
        }
    }
}
