using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NominaPISIB.Aplicacion.Servicios;

namespace NominaPISIB.Aplicacion.ServiciosImpl
{
    public class EmpleadosVacacionesTotalesServicioImpl : IEmpleadosVacacionesTotalesServicio  
    {
        public Task<bool> ActualizarVacacionesTotalesAsync(int empleadoId, DateTime nuevaFechaInicio, DateTime nuevaFechaFin, int nuevosDiasTotales)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EliminarVacacionesTotalesAsync(int empleadoId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NotificarVacacionesTotalesActualizadasAsync(int empleadoId, string mensajeNotificacion)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NotificarVacacionesTotalesEliminadasAsync(int empleadoId, string mensajeNotificacion)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NotificarVacacionesTotalesRegistradasAsync(int empleadoId, string mensajeNotificacion)
        {
            throw new NotImplementedException();
        }

        public Task<string> ObtenerDetallesVacacionesTotalesAsync(int empleadoId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> ObtenerVacacionesTotalesPorEmpleadoAsync(int empleadoId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegistrarVacacionesTotalesAsync(int empleadoId, DateTime fechaInicio, DateTime fechaFin, int diasTotales)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ValidarVacacionesTotalesAsync(int empleadoId, DateTime fechaInicio, DateTime fechaFin, int diasTotales)
        {
            throw new NotImplementedException();
        }
    }
}
