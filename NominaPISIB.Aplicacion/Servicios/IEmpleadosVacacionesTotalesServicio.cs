using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace NominaPISIB.Aplicacion.Servicios
{
    [ServiceContract]
    public interface IEmpleadosVacacionesTotalesServicio
    {
        [OperationContract]
        Task<bool> RegistrarVacacionesTotalesAsync(int empleadoId, DateTime fechaInicio, DateTime fechaFin, int diasTotales);
        [OperationContract]
        Task<bool> ActualizarVacacionesTotalesAsync(int empleadoId, DateTime nuevaFechaInicio, DateTime nuevaFechaFin, int nuevosDiasTotales);
        [OperationContract]
        Task<bool> EliminarVacacionesTotalesAsync(int empleadoId);
        [OperationContract]
        Task<IEnumerable<string>> ObtenerVacacionesTotalesPorEmpleadoAsync(int empleadoId);
        [OperationContract]
        Task<string> ObtenerDetallesVacacionesTotalesAsync(int empleadoId);
        [OperationContract]
        Task<bool> NotificarVacacionesTotalesRegistradasAsync(int empleadoId, string mensajeNotificacion);
        [OperationContract]
        Task<bool> NotificarVacacionesTotalesActualizadasAsync(int empleadoId, string mensajeNotificacion);
        [OperationContract]
        Task<bool> NotificarVacacionesTotalesEliminadasAsync(int empleadoId, string mensajeNotificacion);
        [OperationContract]
        Task<bool> ValidarVacacionesTotalesAsync(int empleadoId, DateTime fechaInicio, DateTime fechaFin, int diasTotales);
    }
}
