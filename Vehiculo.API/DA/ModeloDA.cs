using Abstracciones.Interfaces.DA;
using Abstracciones.Modelos;
using Dapper;
using Microsoft.Data.SqlClient;

namespace DA
{
    public class ModeloDA : IModeloDA
    {

        private IRepositorioDapper _repositorioDapper;
        private SqlConnection _sqlConnection;

        public ModeloDA(IRepositorioDapper repositorioDapper)
        {
            _repositorioDapper = repositorioDapper;
            _sqlConnection = _repositorioDapper.ObtenerRepositorio();
        }

        public async Task<IEnumerable<Modelo>> Obtener()
        {
            var query = @"ObtenerModelos";
            var resultadoConsulta = await _sqlConnection.QueryAsync<Modelo>(query);
            return resultadoConsulta;
        }

        public async Task<IEnumerable<Modelo>> Obtener(Guid idMarca)
        {
            var query = @"ObtenerModelosPorMarca";
            var resultadoConsulta = await _sqlConnection.QueryAsync<Modelo>(query, new
            {
                IdMarca = idMarca
            });
            return resultadoConsulta;
        }
    }
}
