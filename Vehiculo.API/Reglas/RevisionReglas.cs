using Abstracciones.Interfaces.Reglas;
using Abstracciones.Interfaces.Servicios;
using Abstracciones.Modelos.Servicios.Revision;

namespace Reglas
{
    public class RevisionReglas : IRevisionReglas
    {

        private readonly IConfiguracion _configuracion;
        private readonly IRevisionServicio _revisionServicio;

        public RevisionReglas(IConfiguracion configuracion, IRevisionServicio revisionServicio)
        {
            _configuracion = configuracion;
            _revisionServicio = revisionServicio;
        }

        public async Task<bool> RevisionEsValida(string placa)
        {
            var resultadoRevision = await _revisionServicio.Obtener(placa);
            if(resultadoRevision == null)
                return false;
            if (ValidarEstado(resultadoRevision) && ValidarPeriodo(resultadoRevision.Periodo))
                return true;
            return false;
        }


        private bool ValidarEstado(Revision resultadoRevision)
        {
            string estadoRevision = _configuracion.ObtenerValor("EstadoRevisionSatisfactorio");
            return resultadoRevision.Resultado == estadoRevision;
        }

        private static string ObtenerPeriodoActual()
        {
            return $"{DateTime.Now.Month}-{DateTime.Now.Year}";
        }

        private static bool ValidarPeriodo(string periodo)
        {
            var periodoActual = ObtenerPeriodoActual();
            return periodo == periodoActual;
        }
    }
}
