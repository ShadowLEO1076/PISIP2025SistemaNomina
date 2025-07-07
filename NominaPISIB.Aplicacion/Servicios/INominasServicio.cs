using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace NominaPISIB.Aplicacion.Servicios
{
    [ServiceContract]
    public interface INominasServicio

    // : IService<Nominas> METODOS PARA CRUD DE NOMINAS
    {
        [OperationContract]
        Task<bool> RegistrarNominaAsync(int empleadoId, DateTime fechaPago, decimal monto);
        [OperationContract]
        Task<bool> ActualizarNominaAsync(int nominaId, DateTime nuevaFechaPago, decimal nuevoMonto);
        [OperationContract]
        Task<bool> EliminarNominaAsync(int nominaId);
        [OperationContract]
        Task<IEnumerable<string>> ObtenerNominasPorEmpleadoAsync(int empleadoId);
        [OperationContract]
        Task<IEnumerable<string>> ObtenerNominasPorFechaAsync(DateTime fecha);
        [OperationContract]
        Task<string> ObtenerDetallesNominaAsync(int nominaId);
        [OperationContract]
        Task<bool> NotificarNominaRegistradaAsync(int empleadoId, string mensajeNotificacion);
        [OperationContract]
        Task<bool> NotificarNominaActualizadaAsync(int nominaId, string mensajeNotificacion);
        [OperationContract]
        Task<bool> NotificarNominaEliminadaAsync(int nominaId, string mensajeNotificacion);

        [OperationContract]
        // PARA USAR EN PRUEVAS NUNIT JUNTO CON DTO PARA CONSULTAS DEL DTO: ReporteDescuentosNominaDTO
        Task<List<string>> ObtenerReporteDescuentosNomina(int mes, int anio);


    }
}
