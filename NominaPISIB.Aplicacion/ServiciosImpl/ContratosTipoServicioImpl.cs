using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NominaPISIB.Aplicacion.Servicios;
using NominaPISIB.Infraestructura.AccesoDatos;

namespace NominaPISIB.Aplicacion.ServiciosImpl
{
    public class ContratosTipoServicioImpl : IContratosTipoServicio
    {
        public Task<bool> ActualizarContratoAsync(int contratoId, string nuevoTipoContrato, DateTime nuevaFechaInicio, DateTime nuevaFechaFin)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(ContratosTipo entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(ContratosTipo entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EliminarContratoAsync(int contratoId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ContratosTipo>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ContratosTipo> GetByIdAsync(int id)
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

        public Task<string> ObtenerDetallesContratoAsync(int contratoId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegistrarContratoAsync(int empleadoId, string tipoContrato, DateTime fechaInicio, DateTime fechaFin)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ContratosTipo entity)
        {
            throw new NotImplementedException();
        }
    }
}
