using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NominaPISIB.Aplicacion.Servicios;
using NominaPISIB.Infraestructura.AccesoDatos;

namespace NominaPISIB.Aplicacion.ServiciosImpl
{
    public class DescuentosServicioImpl : ServicioImpl<Descuentos>, IDescuentosServicio
    {
        public DescuentosServicioImpl(NominaPISIBContext context) : base(context)
        {
        }

        public Task<bool> ActualizarDescuentoAsync(int descuentoId, decimal nuevoMonto, string nuevoMotivo, DateTime nuevaFecha)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EliminarDescuentoAsync(int descuentoId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NotificarDescuentoActualizadoAsync(int descuentoId, string mensajeNotificacion)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NotificarDescuentoEliminadoAsync(int descuentoId, string mensajeNotificacion)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NotificarDescuentoRegistradoAsync(int empleadoId, string mensajeNotificacion)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> ObtenerDescuentosPorEmpleadoAsync(int empleadoId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> ObtenerDescuentosPorFechaAsync(DateTime fecha)
        {
            throw new NotImplementedException();
        }

        public Task<string> ObtenerDetallesDescuentoAsync(int descuentoId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegistrarDescuentoAsync(int empleadoId, decimal monto, string motivo, DateTime fecha)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ValidarDescuentoAsync(int empleadoId, decimal monto, string motivo, DateTime fecha)
        {
            throw new NotImplementedException();
        }
    }
}
