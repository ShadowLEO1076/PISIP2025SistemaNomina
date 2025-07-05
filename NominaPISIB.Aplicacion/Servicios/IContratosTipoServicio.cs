using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;


namespace NominaPISIB.Aplicacion.Servicios
{
    [ServiceContract]
    public interface IContratosTipoServicio
    {
        [OperationContract]
        Task<bool> RegistrarContratoAsync(int empleadoId, string tipoContrato, DateTime fechaInicio, DateTime fechaFin);
        [OperationContract]
        Task<bool> ActualizarContratoAsync(int contratoId, string nuevoTipoContrato, DateTime nuevaFechaInicio, DateTime nuevaFechaFin);
        [OperationContract]
        Task<bool> EliminarContratoAsync(int contratoId);
        [OperationContract]
        Task<IEnumerable<string>> ObtenerContratosPorEmpleadoAsync(int empleadoId);
        [OperationContract]
        Task<string> ObtenerDetallesContratoAsync(int contratoId);

        [OperationContract]
        Task<bool> NotificarContratoRegistradoAsync(int empleadoId, string mensajeNotificacion);

        [OperationContract]
        Task<bool> NotificarContratoActualizadoAsync(int contratoId, string mensajeNotificacion);

        [OperationContract]
        Task<bool> NotificarContratoEliminadoAsync(int contratoId, string mensajeNotificacion);
    }
}
