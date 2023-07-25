using BASE_DATOS_RESTFUL_DOTNET_KGARCIA_SERVIDOR.Context;
using BASE_DATOS_RESTFUL_DOTNET_KGARCIA_SERVIDOR.DTO;
using BASE_DATOS_RESTFUL_DOTNET_KGARCIA_SERVIDOR.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

namespace BASE_DATOS_RESTFUL_DOTNET_KGARCIA_SERVIDOR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EurekaController : ControllerBase
    {
        private readonly IntegracionContext _context;

        public EurekaController(IntegracionContext context)
        {
            _context = context;
        }

        [HttpGet("GetMovimientos")]
        public ActionResult<IEnumerable<Movimiento>> GetMovimietos(string cuenta)
        {
            var movimientos = from q in _context.Movimientos join tm in _context.Tipomovimientos on q.ChrTipocodigo equals tm.ChrTipocodigo where q.ChrCuencodigo.Equals(cuenta) select q;
            return movimientos.Include(e=> e.TipoMovimiento).ToList();
        }

        [HttpPost("registrarDeposito")]
        public async Task<ActionResult<Movimiento>> RegistrarDeposito(RegistroDeposito registro)
        {
            var cuenta = _context.Cuenta.FirstOrDefault(i => i.ChrCuencodigo == registro.Cuenta);
            var ultimoMovimiento = _context.Movimientos.OrderByDescending(i => i.IntMovinumero).First();
            if(cuenta == null)
            {
                BadRequest("La cuenta que ingresas es incorrecta o no exista");
            }
            var numero = ultimoMovimiento.IntMovinumero + 1;
            var movimiento = new Movimiento
            {
                ChrCuencodigo = registro.Cuenta,
                IntMovinumero = numero,
                DttMovifecha = DateOnly.FromDateTime(DateTime.Now),
                ChrEmplcodigo = cuenta.ChrEmplcreacuenta,
                ChrTipocodigo = "001",
                DecMoviimporte = registro.importe
            };
            _context.Movimientos.Add(movimiento);
            await _context.SaveChangesAsync();
            return Ok("Deposito registrado correctamente");
        }
    }
}
