using Abstracciones.Interfaces.API;
using Abstracciones.Interfaces.Flujo;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModeloController : ControllerBase, IModeloController
    {

        private readonly IModeloFlujo _modeloFlujo;

        public ModeloController(IModeloFlujo modeloFlujo)
        {
            _modeloFlujo = modeloFlujo;
        }

        [HttpGet]
        public async Task<IActionResult> Obtener()
        {
            var resultado = await _modeloFlujo.Obtener();
            if (!resultado.Any())
                return NoContent();
            return Ok(resultado);
        }

        [HttpGet("{idMarca}")]
        public async Task<IActionResult> Obtener([FromRoute] Guid idMarca)
        {
            var resultado = await _modeloFlujo.Obtener(idMarca);
            if (!resultado.Any())
                return NoContent();
            return Ok(resultado);
        }
    }
}
