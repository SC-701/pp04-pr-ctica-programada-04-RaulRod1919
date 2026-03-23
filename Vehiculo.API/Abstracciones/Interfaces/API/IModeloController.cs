using Microsoft.AspNetCore.Mvc;

namespace Abstracciones.Interfaces.API
{
    public interface IModeloController
    {

        Task<IActionResult> Obtener();
        Task<IActionResult> Obtener(Guid idMarca);

    }
}
