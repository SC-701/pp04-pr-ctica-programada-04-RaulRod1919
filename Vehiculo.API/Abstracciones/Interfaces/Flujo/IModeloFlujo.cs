using Abstracciones.Modelos;

namespace Abstracciones.Interfaces.Flujo
{
    public interface IModeloFlujo
    {

        Task<IEnumerable<Modelo>> Obtener();
        Task<IEnumerable<Modelo>> Obtener(Guid idMarca);

    }
}
