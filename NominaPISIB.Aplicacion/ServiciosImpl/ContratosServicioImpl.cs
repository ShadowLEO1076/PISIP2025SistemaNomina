using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NominaPISIB.Aplicacion.Servicios;
using NominaPISIB.Infraestructura.AccesoDatos;

namespace NominaPISIB.Aplicacion.ServiciosImpl
{
    public class ContratosServicioImpl : IContratosServicio
    {
        public Task<bool> ActualizarContratoAsync(int contratoId, DateTime nuevaFechaInicio, DateTime nuevaFechaFin, string nuevoTipoContrato)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Contratos entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Contratos entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EliminarContratoAsync(int contratoId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Contratos>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Contratos> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NotificarContratoActualizadoAsync(int contratoId, string mensajeNotificacion)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NotificarContratoEliminadoAsync(int contratoId, string mensajeNotificacion)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NotificarContratoRegistradoAsync(int empleadoId, string mensajeNotificacion)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> ObtenerContratosPorEmpleadoAsync(int empleadoId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> ObtenerContratosPorFechaAsync(DateTime fecha)
        {
            throw new NotImplementedException();
        }

        public Task<string> ObtenerDetallesContratoAsync(int contratoId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegistrarContratoAsync(int empleadoId, DateTime fechaInicio, DateTime fechaFin, string tipoContrato)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Contratos entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ValidarContratoAsync(int empleadoId, DateTime fechaInicio, DateTime fechaFin, string tipoContrato)
        {
            throw new NotImplementedException();
        }
    }
}
