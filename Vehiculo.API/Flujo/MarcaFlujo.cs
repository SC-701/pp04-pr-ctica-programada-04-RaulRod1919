using Abstracciones.Interfaces.DA;
using Abstracciones.Interfaces.Flujo;
using Abstracciones.Modelos;

namespace Flujo
{
    public class MarcaFlujo : IMarcaFlujo
    {

        private readonly IMarcaDA _marcaDA;

        public MarcaFlujo(IMarcaDA marcaDA)
        {
            _marcaDA = marcaDA;
        }

        public Task<IEnumerable<Marca>> Obtener()
        {
            return _marcaDA.Obtener();
        }
    }
}
