using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NominaPISIB.Aplicacion.Servicios;

namespace NominaPISIB.Aplicacion.ServiciosImpl
{
    public class AprobacionVacacionesServicioImpl : IAprobacionVacacionesServicio
    {
        public Task<bool> AprobarVacacionesAsync(int solicitudId, bool aprobar)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NotificarAprobacionAsync(int solicitudId, string mensajeNotificacion)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NotificarRechazoAsync(int solicitudId, string mensajeNotificacion)
        {
            throw new NotImplementedException();
        }

        public Task<string> ObtenerDetallesSolicitudAsync(int solicitudId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> ObtenerHistorialSolicitudesAsync(int empleadoId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> ObtenerSolicitudesPendientesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> RechazarVacacionesAsync(int solicitudId, string motivoRechazo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ValidarSolicitudVacacionesAsync(int solicitudId, int empleadoId)
        {
            throw new NotImplementedException();
        }
    }
}
