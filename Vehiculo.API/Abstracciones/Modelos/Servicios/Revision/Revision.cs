namespace Abstracciones.Modelos.Servicios.Revision
{
    public class Revision
    {

        public string Placa { get; set; }
        public IEnumerable<Falta> Faltas { get; set; }
        public string Periodo { get; set; }
        public string Resultado { get; set; }

    }
}
