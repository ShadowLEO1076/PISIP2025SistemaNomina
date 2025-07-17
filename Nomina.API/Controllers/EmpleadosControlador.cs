using Microsoft.AspNetCore.Mvc;
using NominaPISIB.Aplicacion.Servicios;
using NominaPISIB.Infraestructura.AccesoDatos;

namespace Nomina.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmpleadosControlador : ControllerBase
    {
        private readonly IEmpleadosServicio _empleServ;

        public EmpleadosControlador(IEmpleadosServicio emple)
        {
            _empleServ = emple;
        }

        [HttpGet("ObtenerEmpleadoPorNombre")]
        public async Task<IActionResult> ObtenerEmpleadoPorNombre([FromQuery]string name,[FromQuery] string lastname) 
        {
            try
            {
                var empleado = await _empleServ.ObtenerEmpleadoPorNombre(name, lastname);
                return Ok(empleado);
            }
            catch(Exception ex) { 
            return StatusCode(500, $"Error al traer los datos. {ex.Message}");
            }
        }

        [HttpPost("AddAsync")]
        public async Task<IActionResult> AddAsync([FromBody] Empleados empleado)
        {

            if (empleado == null) {
                return StatusCode(300, $"El dato no puede estar vacio.");
            }
            try
            {
                await _empleServ.AddAsync(empleado);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"No se pudo ingresar el dato. {ex.Message}");
            }
        }
        [HttpPut("UpdateAsync")]
        public async Task<IActionResult> UpdateAsync([FromBody] Empleados empleado)
        {
            if (empleado == null) 
                {
                    return StatusCode(300, $"El dato no puede estar vacio.");
                }
            try
            {
                await _empleServ.UpdateAsync(empleado);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"No se pudo actualizar el dato. {ex.Message}");
            }
        }

        [HttpGet("GetAllAsync")]
        public async Task<IActionResult> GetAllAync()
        {
            try
            {
                var datos =  await _empleServ.GetAllAsync();
                return Ok(datos);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"No se pudo traer los datos. {ex.Message}");
            }
        }
    }
}
