using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NominaPISIB.Aplicacion.Servicios;

namespace NominaPISIB.Aplicacion.ServiciosImpl
{
    public class NominasServicioImpl : INominasServicio
    {
        public Task<bool> ActualizarNominaAsync(int nominaId, DateTime nuevaFechaPago, decimal nuevoMonto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EliminarNominaAsync(int nominaId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NotificarNominaActualizadaAsync(int nominaId, string mensajeNotificacion)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NotificarNominaEliminadaAsync(int nominaId, string mensajeNotificacion)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NotificarNominaRegistradaAsync(int empleadoId, string mensajeNotificacion)
        {
            throw new NotImplementedException();
        }

        public Task<string> ObtenerDetallesNominaAsync(int nominaId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> ObtenerNominasPorEmpleadoAsync(int empleadoId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> ObtenerNominasPorFechaAsync(DateTime fecha)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegistrarNominaAsync(int empleadoId, DateTime fechaPago, decimal monto)
        {
            throw new NotImplementedException();
        }
    }
}
