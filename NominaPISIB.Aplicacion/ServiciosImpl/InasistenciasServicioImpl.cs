using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NominaPISIB.Aplicacion.Servicios;

namespace NominaPISIB.Aplicacion.ServiciosImpl
{
    public class InasistenciasServicioImpl : IInasistenciasServicio
    {
        public Task<bool> ActualizarInasistenciaAsync(int inasistenciaId, DateTime nuevaFecha, string nuevoMotivo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EliminarInasistenciaAsync(int inasistenciaId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NotificarInasistenciaActualizadaAsync(int inasistenciaId, string mensajeNotificacion)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NotificarInasistenciaEliminadaAsync(int inasistenciaId, string mensajeNotificacion)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NotificarInasistenciaRegistradaAsync(int empleadoId, string mensajeNotificacion)
        {
            throw new NotImplementedException();
        }

        public Task<string> ObtenerDetallesInasistenciaAsync(int inasistenciaId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> ObtenerInasistenciasPendientesAsync(int empleadoId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> ObtenerInasistenciasPorEmpleadoAsync(int empleadoId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> ObtenerInasistenciasPorFechaAsync(DateTime fecha)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegistrarInasistenciaAsync(int empleadoId, DateTime fecha, string motivo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ValidarInasistenciaAsync(int empleadoId, DateTime fecha, string motivo)
        {
            throw new NotImplementedException();
        }
    }
}
