using Abstracciones.Interfaces.API;
using Abstracciones.Interfaces.Flujo;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcaController : ControllerBase, IMarcaController
    {

        private readonly IMarcaFlujo _marcaFlujo;

        public MarcaController(IMarcaFlujo marcaFlujo)
        {
            _marcaFlujo = marcaFlujo;
        }

        [HttpGet]
        public async Task<IActionResult> Obtener()
        {
            var resultado = await _marcaFlujo.Obtener();
            if(!resultado.Any())
                return NoContent();
            return Ok(resultado);
        }
    }
}
