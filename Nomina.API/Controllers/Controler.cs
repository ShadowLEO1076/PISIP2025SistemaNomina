using Microsoft.AspNetCore.Mvc;

namespace Nomina.API.Controllers
{
    public class Controler
    {
        [ApiController]
        [Route("api/[controller]")]
        public class NominaController : ControllerBase
        {
            [HttpGet]
            public string saludo()
            {
                return "Hola desde el controlador de nómina";
            }
           /* public ActionResult Get()
            {
                // Aquí iría la lógica para obtener las nóminas
                return Ok("Lista de nóminas");
            }*/
        }
    }
}