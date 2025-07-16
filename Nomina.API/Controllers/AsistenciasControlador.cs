using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using NominaPISIB.Aplicacion.DTO.DTOs;
using NominaPISIB.Aplicacion.Servicios;
using NominaPISIB.Infraestructura.AccesoDatos;

namespace Nomina.API.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class AsistenciasControlador : ControllerBase
    {
        private readonly IAsistenciasServicio _serv;

        public AsistenciasControlador(IAsistenciasServicio asiServicio)
        {
            _serv = asiServicio;
        }

        [HttpGet("empleado")]
        public async Task<IActionResult> ObtenerAsistenciasEmpleadoPorAnioYMes([FromQuery] string name, [FromQuery] string lastname, [FromQuery] int year, [FromQuery] int month)
        {
            try
            {

                var resultado = await _serv.ObtenerAsistenciasEmpleadoPorAnioYMes(name, lastname, year, month);
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
                return StatusCode(500, "Error interno");
            }
        }

        [HttpGet]
        public Task<IEnumerable<Asistencias>> GetAllAsync()
        {

            return _serv.GetAllAsync();
        }
    }
}

