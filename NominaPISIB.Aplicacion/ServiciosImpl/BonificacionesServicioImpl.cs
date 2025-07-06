using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NominaPISIB.Aplicacion.Servicios;
using NominaPISIB.Infraestructura.AccesoDatos;

namespace NominaPISIB.Aplicacion.ServiciosImpl
{
    public class BonificacionesServicioImpl : IBonificacionesServicio
    {
        public Task<bool> ActualizarBonificacionAsync(int bonificacionId, decimal nuevoMonto, string nuevaDescripcion)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Bonificaciones entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Bonificaciones entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EliminarBonificacionAsync(int bonificacionId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Bonificaciones>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Bonificaciones> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> ObtenerBonificacionesPorEmpleadoAsync(int empleadoId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegistrarBonificacionAsync(int empleadoId, decimal monto, string descripcion)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Bonificaciones entity)
        {
            throw new NotImplementedException();
        }
    }
}
