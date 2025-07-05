using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace NominaPISIB.Aplicacion.Servicios
{
    [ServiceContract]
    public interface IDescuentosServicio
    {
        [OperationContract]
        Task<bool> RegistrarDescuentoAsync(int empleadoId, decimal monto, string motivo, DateTime fecha);
        [OperationContract]
        Task<bool> ActualizarDescuentoAsync(int descuentoId, decimal nuevoMonto, string nuevoMotivo, DateTime nuevaFecha);
        [OperationContract]
        Task<bool> EliminarDescuentoAsync(int descuentoId);
        [OperationContract]
        Task<IEnumerable<string>> ObtenerDescuentosPorEmpleadoAsync(int empleadoId);
        [OperationContract]
        Task<IEnumerable<string>> ObtenerDescuentosPorFechaAsync(DateTime fecha);

        [OperationContract]
        Task<string> ObtenerDetallesDescuentoAsync(int descuentoId);
        [OperationContract]
        Task<bool> NotificarDescuentoRegistradoAsync(int empleadoId, string mensajeNotificacion);
        [OperationContract]
        Task<bool> NotificarDescuentoActualizadoAsync(int descuentoId, string mensajeNotificacion);
        [OperationContract]
        Task<bool> NotificarDescuentoEliminadoAsync(int descuentoId, string mensajeNotificacion);
        [OperationContract]
        Task<bool> ValidarDescuentoAsync(int empleadoId, decimal monto, string motivo, DateTime fecha);
        

    }
}
