using Abstracciones.Interfaces.Reglas;
using Abstracciones.Interfaces.Servicios;

namespace Reglas
{
    public class RegistroReglas : IRegistroReglas
    {

        private readonly IRegistroServicio _registroServicio;
        private readonly IConfiguracion _configuracion;

        public RegistroReglas(IConfiguracion configuracion, IRegistroServicio registroServicio)
        {
            _configuracion = configuracion;
            _registroServicio = registroServicio;
        }

        public async Task<bool> VehiculoEstaRegistrado(string placa, string email)
        {
            var resultadoRegistro = await _registroServicio.Obtener(placa);
            return (resultadoRegistro != null && resultadoRegistro.Email == email);
        }
    }
}
