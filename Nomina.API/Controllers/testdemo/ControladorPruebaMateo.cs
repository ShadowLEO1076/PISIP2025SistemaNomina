using Microsoft.AspNetCore.Mvc;

namespace Nomina.API.Controllers.testdemo
{
    [ApiController]
    [Route("api/nomina/[controller]")]
    public class ControladorPruebaMateo : ControllerBase
    {

        [HttpGet]
        public string Saludo()
        {
            return "Hola mundo";
        }

        [HttpGet("{nombre}")]
        public string SaludoAPersona(string nombre) 
        {
            return "Hola" + " " + nombre;
        }
            
    }
}
