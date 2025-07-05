using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NominaPISIB.Aplicacion.Servicios;

namespace NominaPISIB.Aplicacion.ServiciosImpl
{
    public class LicenciasServicioImpl : ILicenciasServicio
    {
        public Task<bool> AprobarLicenciaAsync(int licenciaId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NotificarLicenciaAprobadaAsync(int licenciaId, string mensajeNotificacion)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NotificarLicenciaRechazadaAsync(int licenciaId, string mensajeNotificacion)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NotificarLicenciaSolicitadaAsync(int empleadoId, string mensajeNotificacion)
        {
            throw new NotImplementedException();
        }

        public Task<string> ObtenerDetallesLicenciaAsync(int licenciaId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> ObtenerLicenciasPorEmpleadoAsync(int empleadoId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> ObtenerTodasLicenciasAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> RechazarLicenciaAsync(int licenciaId, string motivoRechazo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SolicitarLicenciaAsync(int empleadoId, DateTime fechaInicio, DateTime fechaFin, string motivo)
        {
            throw new NotImplementedException();
        }
    }
}
