using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NominaPISIB.Aplicacion.Servicios;

namespace NominaPISIB.Aplicacion.ServiciosImpl
{
    public class SolicitudVacacionesServicioImpl : ISolicitudVacacionesServicio
    {
        public Task<bool> AprobarVacacionesAsync(int solicitudId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NotificarSolicitudVacacionesAsync(int empleadoId, string mensajeNotificacion)
        {
            throw new NotImplementedException();
        }

        public Task<string> ObtenerDetallesSolicitudVacacionesAsync(int solicitudId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> ObtenerSolicitudesVacacionesPorEmpleadoAsync(int empleadoId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> ObtenerTodasSolicitudesVacacionesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> RechazarVacacionesAsync(int solicitudId, string motivoRechazo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SolicitarVacacionesAsync(int empleadoId, DateTime fechaInicio, DateTime fechaFin)
        {
            throw new NotImplementedException();
        }
    }
}
