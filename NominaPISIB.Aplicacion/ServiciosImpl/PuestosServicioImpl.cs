using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using NominaPISIB.Aplicacion.Servicios;
using NominaPISIB.Dominio.Modelos.Abstracciones;
using NominaPISIB.Infraestructura.AccesoDatos;
using NominaPISIB.Infraestructura.AccesoDatos.Repositorio;

namespace NominaPISIB.Aplicacion.ServiciosImpl
{
    public class PuestosServicioImpl : ServicioImpl<Puestos>, IPuestosServicio
    {
        IPuestosRepo _repo;
        private readonly NominaPISIBContext _context;
        public PuestosServicioImpl(NominaPISIBContext context) : base(context)
        {
            _context = context;
            _repo = new PuestosRepoImpl(context);
        }

        public async Task<List<Puestos>> GetAll()
        {
            return await  _repo.GetAll();
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
