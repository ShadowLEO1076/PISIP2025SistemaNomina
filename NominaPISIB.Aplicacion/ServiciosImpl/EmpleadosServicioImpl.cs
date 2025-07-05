using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NominaPISIB.Aplicacion.Servicios;

namespace NominaPISIB.Aplicacion.ServiciosImpl
{
    public class EmpleadosServicioImpl : IEmpleadosServicio
    {
        public Task<bool> ActualizarEmpleadoAsync(int empleadoId, string nombre, string apellido, DateTime fechaNacimiento, string puesto, decimal salario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EliminarEmpleadoAsync(int empleadoId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NotificarEmpleadoActualizadoAsync(int empleadoId, string mensajeNotificacion)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NotificarEmpleadoEliminadoAsync(int empleadoId, string mensajeNotificacion)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NotificarEmpleadoRegistradoAsync(int empleadoId, string mensajeNotificacion)
        {
            throw new NotImplementedException();
        }

        public Task<string> ObtenerDetallesEmpleadoAsync(int empleadoId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> ObtenerEmpleadosAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegistrarEmpleadoAsync(string nombre, string apellido, DateTime fechaNacimiento, string puesto, decimal salario)
        {
            throw new NotImplementedException();
        }
    }
}
