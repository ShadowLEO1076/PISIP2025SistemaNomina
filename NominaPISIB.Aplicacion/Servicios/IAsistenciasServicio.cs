using NominaPISIB.Aplicacion.DTO.DTOs;
using NominaPISIB.Infraestructura.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace NominaPISIB.Aplicacion.Servicios
{
    [ServiceContract]
    public interface IAsistenciasServicio : IService<Asistencias>
    {
        //hace lo que dice, con esto podremos hacer la nómina -> Mateo Vasquez
        [OperationContract]
        Task<List<AsistenciasEmpleadosDTO>> ObtenerAsistenciasEmpleadoPorAnioYMes(string name, string lastname, int year, int month);
        [OperationContract]
        Task<bool> RegistrarAsistenciaAsync(int empleadoId, DateTime fechaHoraEntrada, DateTime fechaHoraSalida);
        [OperationContract]
        Task<bool> ActualizarAsistenciaAsync(int asistenciaId, DateTime nuevaFechaHoraEntrada, DateTime nuevaFechaHoraSalida);
        [OperationContract]
        Task<bool> EliminarAsistenciaAsync(int asistenciaId);
        [OperationContract]
        Task<IEnumerable<string>> ObtenerAsistenciasPorEmpleadoAsync(int empleadoId);
        [OperationContract]
        Task<IEnumerable<string>> ObtenerAsistenciasPorFechaAsync(DateTime fecha);
        [OperationContract]
        Task<string> ObtenerDetallesAsistenciaAsync(int asistenciaId);
        [OperationContract]
        Task<bool> NotificarAsistenciaRegistradaAsync(int empleadoId, string mensajeNotificacion);
        [OperationContract]
        Task<bool> NotificarAsistenciaActualizadaAsync(int asistenciaId, string mensajeNotificacion);
        [OperationContract]
        Task<bool> NotificarAsistenciaEliminadaAsync(int asistenciaId, string mensajeNotificacion);
        [OperationContract]
        Task<bool> ValidarAsistenciaAsync(int empleadoId, DateTime fechaHoraEntrada, DateTime fechaHoraSalida);
        [OperationContract]
        Task<IEnumerable<string>> ObtenerAsistenciasPendientesAsync(int empleadoId);


    }
}
