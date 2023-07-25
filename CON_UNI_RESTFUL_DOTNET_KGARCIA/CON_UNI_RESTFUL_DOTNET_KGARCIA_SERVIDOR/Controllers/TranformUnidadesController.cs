using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CON_UNI_RESTFUL_DOTNET_KGARCIA_SERVIDOR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TranformUnidadesController : ControllerBase
    {
        [HttpGet("centigradosAfahrenheit")]
        public double centigradosAfahrenheit(double centigrados)
        {
            return (centigrados * 9 / 5) + 32;
        }

        [HttpGet("fahrenheitAcentigrados")]
        public double fahrenheitAcentigrados(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
