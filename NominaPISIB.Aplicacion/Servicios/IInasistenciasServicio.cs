using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace NominaPISIB.Aplicacion.Servicios
{
    [ServiceContract]
    public interface IInasistenciasServicio
    {
        [OperationContract]
        Task<bool> RegistrarInasistenciaAsync(int empleadoId, DateTime fecha, string motivo);
        [OperationContract]
        Task<bool> ActualizarInasistenciaAsync(int inasistenciaId, DateTime nuevaFecha, string nuevoMotivo);
        [OperationContract]
        Task<bool> EliminarInasistenciaAsync(int inasistenciaId);
        [OperationContract]
        Task<IEnumerable<string>> ObtenerInasistenciasPorEmpleadoAsync(int empleadoId);
        [OperationContract]
        Task<IEnumerable<string>> ObtenerInasistenciasPorFechaAsync(DateTime fecha);
        [OperationContract]
        Task<string> ObtenerDetallesInasistenciaAsync(int inasistenciaId);
        [OperationContract]
        Task<bool> NotificarInasistenciaRegistradaAsync(int empleadoId, string mensajeNotificacion);
        [OperationContract]
        Task<bool> NotificarInasistenciaActualizadaAsync(int inasistenciaId, string mensajeNotificacion);
        [OperationContract]
        Task<bool> NotificarInasistenciaEliminadaAsync(int inasistenciaId, string mensajeNotificacion);

        [OperationContract]
        Task<bool> ValidarInasistenciaAsync(int empleadoId, DateTime fecha, string motivo);

        [OperationContract]
        Task<IEnumerable<string>> ObtenerInasistenciasPendientesAsync(int empleadoId);
    }
}
