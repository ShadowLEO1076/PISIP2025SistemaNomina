using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace NominaPISIB.Aplicacion.Servicios
{
    [ServiceContract]
    public interface IAprobacionVacacionesServicio
    {
        [OperationContract]
        Task<bool> AprobarVacacionesAsync(int solicitudId, bool aprobar);
        [OperationContract]
        Task<bool> RechazarVacacionesAsync(int solicitudId, string motivoRechazo);
        [OperationContract]
        Task<IEnumerable<string>> ObtenerSolicitudesPendientesAsync();
        [OperationContract]
        Task<IEnumerable<string>> ObtenerHistorialSolicitudesAsync(int empleadoId);
        [OperationContract]
        Task<string> ObtenerDetallesSolicitudAsync(int solicitudId);
        [OperationContract]
        Task<bool> NotificarAprobacionAsync(int solicitudId, string mensajeNotificacion);
        [OperationContract]
        Task<bool> NotificarRechazoAsync(int solicitudId, string mensajeNotificacion);
        [OperationContract]
        Task<bool> ValidarSolicitudVacacionesAsync(int solicitudId, int empleadoId);
        
        

    }

}
