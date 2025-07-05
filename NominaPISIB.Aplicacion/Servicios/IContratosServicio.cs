using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace NominaPISIB.Aplicacion.Servicios
{
    [ServiceContract]
    public interface IContratosServicio
    {
        [OperationContract]
        Task<bool> RegistrarContratoAsync(int empleadoId, DateTime fechaInicio, DateTime fechaFin, string tipoContrato);
        [OperationContract]

        Task<bool> ActualizarContratoAsync(int contratoId, DateTime nuevaFechaInicio, DateTime nuevaFechaFin, string nuevoTipoContrato);
        [OperationContract]
        Task<bool> EliminarContratoAsync(int contratoId);
        [OperationContract]
        Task<IEnumerable<string>> ObtenerContratosPorEmpleadoAsync(int empleadoId);
        [OperationContract]
        Task<IEnumerable<string>> ObtenerContratosPorFechaAsync(DateTime fecha);
        [OperationContract]
        Task<string> ObtenerDetallesContratoAsync(int contratoId);
        [OperationContract]
        Task<bool> NotificarContratoRegistradoAsync(int empleadoId, string mensajeNotificacion);
        [OperationContract]
        Task<bool> NotificarContratoActualizadoAsync(int contratoId, string mensajeNotificacion);
        [OperationContract]
        Task<bool> NotificarContratoEliminadoAsync(int contratoId, string mensajeNotificacion);
        [OperationContract]
        Task<bool> ValidarContratoAsync(int empleadoId, DateTime fechaInicio, DateTime fechaFin, string tipoContrato);
        


    }
}
