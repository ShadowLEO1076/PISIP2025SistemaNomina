using NominaPISIB.Aplicacion.DTO.DTOs;
using NominaPISIB.Aplicacion.Servicios;
using NominaPISIB.Dominio.Modelos.Abstracciones;
using NominaPISIB.Infraestructura.AccesoDatos;
using NominaPISIB.Infraestructura.AccesoDatos.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaPISIB.Aplicacion.ServiciosImpl
{
    public class AsistenciasServicioImpl : ServicioImpl<Asistencias>, IAsistenciasServicio
    {
        private IAsistenciasRepo _repo;

        public AsistenciasServicioImpl(NominaPISIBContext context) : base(context)
        {
            this._repo = new AsistenciasRepoImpl(context);
        }
        public Task<bool> ActualizarAsistenciaAsync(int asistenciaId, DateTime nuevaFechaHoraEntrada, DateTime nuevaFechaHoraSalida)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Asistencias entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Asistencias entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EliminarAsistenciaAsync(int asistenciaId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Asistencias>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Asistencias> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NotificarAsistenciaActualizadaAsync(int asistenciaId, string mensajeNotificacion)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NotificarAsistenciaEliminadaAsync(int asistenciaId, string mensajeNotificacion)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NotificarAsistenciaRegistradaAsync(int empleadoId, string mensajeNotificacion)
        {
            throw new NotImplementedException();
        }

        public async Task<List<AsistenciasEmpleadosDTO>> ObtenerAsistenciasEmpleadoPorAnioYMes(string name, string lastname, int year, int month)
        {
            return await _repo.ObtenerAsistenciasEmpleadoPorAnioYMes(name, lastname, year, month);
        }

        public Task<IEnumerable<string>> ObtenerAsistenciasPendientesAsync(int empleadoId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> ObtenerAsistenciasPorEmpleadoAsync(int empleadoId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> ObtenerAsistenciasPorFechaAsync(DateTime fecha)
        {
            throw new NotImplementedException();
        }

        public Task<string> ObtenerDetallesAsistenciaAsync(int asistenciaId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegistrarAsistenciaAsync(int empleadoId, DateTime fechaHoraEntrada, DateTime fechaHoraSalida)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Asistencias entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ValidarAsistenciaAsync(int empleadoId, DateTime fechaHoraEntrada, DateTime fechaHoraSalida)
        {
            throw new NotImplementedException();
        }
    }
}
