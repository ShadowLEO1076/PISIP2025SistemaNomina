using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace NominaPISIB.Aplicacion.Servicios
{
    [ServiceContract]
    public interface ISolicitudVacacionesServicio
    {
        [OperationContract]
        Task<bool> SolicitarVacacionesAsync(int empleadoId, DateTime fechaInicio, DateTime fechaFin);
        [OperationContract]
        Task<bool> AprobarVacacionesAsync(int solicitudId);
        [OperationContract]
        Task<bool> RechazarVacacionesAsync(int solicitudId, string motivoRechazo);
        [OperationContract]
        Task<IEnumerable<string>> ObtenerSolicitudesVacacionesPorEmpleadoAsync(int empleadoId);
        [OperationContract]
        Task<string> ObtenerDetallesSolicitudVacacionesAsync(int solicitudId);
        [OperationContract]
        Task<bool> NotificarSolicitudVacacionesAsync(int empleadoId, string mensajeNotificacion);

        [OperationContract]
        Task<IEnumerable<string>> ObtenerTodasSolicitudesVacacionesAsync();
    }
}
