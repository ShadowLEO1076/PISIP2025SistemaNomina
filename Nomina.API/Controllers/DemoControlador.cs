using Microsoft.AspNetCore.Mvc;

namespace Nomina.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NominaController : ControllerBase
    {
        /// <summary>
        /// Primer mensaje para probar la conexión.
        /// </summary>
        [HttpGet("saludo")]
        public ActionResult<string> Saludo()
        {
            return "Hola desde el controlador de nómina";
        }

        /// <summary>
        /// Segundo mensaje de despedida.
        /// </summary>
        [HttpGet("despedida")]
        public ActionResult<string> Despedida()
        {
            return "Adiós desde el controlador de nómina";
        }
        // metodo de prueba para obtener un nombre y imprimir con un saludo

        [HttpGet("saludo/{nombre}")]
        public ActionResult<string> SaludoConNombre(string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                return BadRequest("El nombre no puede estar vacío.");
            }
            return $"Hola, {nombre}! Bienvenido al controlador de nómina.";
        }
    }
}
