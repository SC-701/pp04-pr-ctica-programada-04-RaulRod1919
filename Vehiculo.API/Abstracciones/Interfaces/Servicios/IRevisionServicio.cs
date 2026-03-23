using Abstracciones.Modelos.Servicios.Revision;

namespace Abstracciones.Interfaces.Servicios
{
    public interface IRevisionServicio
    {

        public Task<Revision> Obtener(string placa);

    }
}
