using Abstracciones.Interfaces.DA;
using Abstracciones.Interfaces.Flujo;
using Abstracciones.Modelos;

namespace Flujo
{
    public class ModeloFlujo : IModeloFlujo
    {

        private readonly IModeloDA _modeloDA;

        public ModeloFlujo(IModeloDA modeloDA)
        {
            _modeloDA = modeloDA;
        }

        public Task<IEnumerable<Modelo>> Obtener()
        {
            return _modeloDA.Obtener();
        }

        public Task<IEnumerable<Modelo>> Obtener(Guid idMarca)
        {
            return _modeloDA.Obtener(idMarca);
        }
    }
}
