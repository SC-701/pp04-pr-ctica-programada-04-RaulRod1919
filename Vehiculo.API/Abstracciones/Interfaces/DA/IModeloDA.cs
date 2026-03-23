using Abstracciones.Modelos;

namespace Abstracciones.Interfaces.DA
{
    public interface IModeloDA
    {

        Task<IEnumerable<Modelo>> Obtener();
        Task<IEnumerable<Modelo>> Obtener(Guid idMarca);
    }
}
