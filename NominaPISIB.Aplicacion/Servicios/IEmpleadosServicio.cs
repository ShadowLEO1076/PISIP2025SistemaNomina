using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using NominaPISIB.Aplicacion.DTO.DTOs;
using NominaPISIB.Infraestructura.AccesoDatos;

namespace NominaPISIB.Aplicacion.Servicios
{
    [ServiceContract]
    public interface IEmpleadosServicio : IService<Empleados>
    {
        [OperationContract]
        public Task<List<HistorialContratoEmpleados>> ObtenerHistorialPorEmpleado(string nameEmpl, string lastnameEmpl);

        [OperationContract]
        Task<List<EmpleadosContratoActivoDTO>> ObtenerContratoActivoEmpleados();
        [OperationContract]
        Task<bool> RegistrarEmpleadoAsync(string nombre, string apellido, DateTime fechaNacimiento, string puesto, decimal salario);
        [OperationContract]
        Task<bool> ActualizarEmpleadoAsync(int empleadoId, string nombre, string apellido, DateTime fechaNacimiento, string puesto, decimal salario);
        [OperationContract]
        Task<bool> EliminarEmpleadoAsync(int empleadoId);
        [OperationContract]
        Task<IEnumerable<string>> ObtenerEmpleadosAsync();
        [OperationContract]
        Task<string> ObtenerDetallesEmpleadoAsync(int empleadoId);
        [OperationContract]
        Task<bool> NotificarEmpleadoRegistradoAsync(int empleadoId, string mensajeNotificacion);
        [OperationContract]
        Task<bool> NotificarEmpleadoActualizadoAsync(int empleadoId, string mensajeNotificacion);
        [OperationContract]
        Task<bool> NotificarEmpleadoEliminadoAsync(int empleadoId, string mensajeNotificacion);

    }
}
