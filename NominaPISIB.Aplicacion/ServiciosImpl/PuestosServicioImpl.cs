using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NominaPISIB.Aplicacion.Servicios;
using NominaPISIB.Infraestructura.AccesoDatos;

namespace NominaPISIB.Aplicacion.ServiciosImpl
{
    public class PuestosServicioImpl : ServicioImpl<Puestos>, IPuestosServicio
    {
        public PuestosServicioImpl(NominaPISIBContext context) : base(context)
        {
        }

        public Task<bool> ActualizarPuestoAsync(int puestoId, string nuevoNombrePuesto, string nuevaDescripcion, decimal nuevoSalarioBase)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EliminarPuestoAsync(int puestoId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NotificarPuestoActualizadoAsync(int puestoId, string mensajeNotificacion)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NotificarPuestoEliminadoAsync(int puestoId, string mensajeNotificacion)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NotificarPuestoRegistradoAsync(int puestoId, string mensajeNotificacion)
        {
            throw new NotImplementedException();
        }

        public Task<string> ObtenerDetallesPuestoAsync(int puestoId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> ObtenerPuestosAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegistrarPuestoAsync(string nombrePuesto, string descripcion, decimal salarioBase)
        {
            throw new NotImplementedException();
        }
    }
}
