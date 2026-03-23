using Abstracciones.Modelos;

namespace Abstracciones.Interfaces.DA
{
    public interface IVehiculoDA
    {
        Task<IEnumerable<VehiculoResponse>> Obtener();
        Task<VehiculoDetalle> Obtener(Guid Id);
        Task<Guid> Agregar(VehiculoRequest Vehiculo);
        Task<Guid> Editar(Guid Id, VehiculoRequest Vehiculo);
        Task<Guid> Eliminar(Guid Id);
    }
}
