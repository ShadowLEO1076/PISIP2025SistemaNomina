using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace NominaPISIB.Aplicacion.Servicios
{
    [ServiceContract]
    public interface ILicenciasServicio
    {
        [OperationContract]
        Task<bool> SolicitarLicenciaAsync(int empleadoId, DateTime fechaInicio, DateTime fechaFin, string motivo);
        [OperationContract]
        Task<bool> AprobarLicenciaAsync(int licenciaId);
        [OperationContract]
        Task<bool> RechazarLicenciaAsync(int licenciaId, string motivoRechazo);
        [OperationContract]
        Task<IEnumerable<string>> ObtenerLicenciasPorEmpleadoAsync(int empleadoId);
        [OperationContract]
        Task<IEnumerable<string>> ObtenerTodasLicenciasAsync();
        [OperationContract]
        Task<string> ObtenerDetallesLicenciaAsync(int licenciaId);

        [OperationContract]
        Task<bool> NotificarLicenciaSolicitadaAsync(int empleadoId, string mensajeNotificacion);

        [OperationContract]
        Task<bool> NotificarLicenciaAprobadaAsync(int licenciaId, string mensajeNotificacion);

        [OperationContract]
        Task<bool> NotificarLicenciaRechazadaAsync(int licenciaId, string mensajeNotificacion);
    }
}
