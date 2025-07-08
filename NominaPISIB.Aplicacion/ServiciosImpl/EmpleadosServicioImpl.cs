using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NominaPISIB.Aplicacion.DTO.DTOs;
using NominaPISIB.Aplicacion.Servicios;
using NominaPISIB.Dominio.Modelos.Abstracciones;
using NominaPISIB.Infraestructura.AccesoDatos;
using NominaPISIB.Infraestructura.AccesoDatos.Repositorio;

namespace NominaPISIB.Aplicacion.ServiciosImpl
{
    public class EmpleadosServicioImpl: ServicioImpl<Empleados>, IEmpleadosServicio
    {
        private IEmpleadosRepo _repo;


        public EmpleadosServicioImpl(NominaPISIBContext context) : base(context)
        {
            this._repo = new EmpleadosRepoImpl(context);
        }
        public Task<List<BonificacionesEmpleadoDTO>> ObtenerBonificacionesDeEmpleadoPorAnio(string name, string lastname, int year)
        {
            return _repo.ObtenerBonificacionesDeEmpleadoPorAnio(name,lastname,year);
        }
        public Task<List<EmpleadosContratoActivoDTO>> ObtenerContratoActivoEmpleados()
        {
            return _repo.ObtenerContratoActivoEmpleados();
        }

        public Task<List<HistorialContratoEmpleados>> ObtenerHistorialPorEmpleado(string nameEmpl, string lastnameEmpl)
        {
            return _repo.ObtenerHistorialPorEmpleado(nameEmpl, lastnameEmpl);
        }

        // para reporte nomina mensual dto
        
        public async Task<List<ReporteNominaMensualDTO>> ObtenerReporteNominaMensual(int mes, int anio)
        {
      
            return await _repo.ObtenerReporteNominaMensual(mes, anio);
        }

       
        public Task<bool> ActualizarEmpleadoAsync(int empleadoId, string nombre, string apellido, DateTime fechaNacimiento, string puesto, decimal salario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EliminarEmpleadoAsync(int empleadoId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NotificarEmpleadoActualizadoAsync(int empleadoId, string mensajeNotificacion)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NotificarEmpleadoEliminadoAsync(int empleadoId, string mensajeNotificacion)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NotificarEmpleadoRegistradoAsync(int empleadoId, string mensajeNotificacion)
        {
            throw new NotImplementedException();
        }

       

        public Task<string> ObtenerDetallesEmpleadoAsync(int empleadoId)
        {
            throw new NotImplementedException();
        }


        public Task<bool> RegistrarEmpleadoAsync(string nombre, string apellido, DateTime fechaNacimiento, string puesto, decimal salario)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> ObtenerEmpleadosAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<ReporteDescuentosNominaDTO>> ObtenerReporteDescuentosMensual(int mes, int anio)
        {
            return await _repo.ObtenerReporteDescuentosMensual(mes, anio);
        }

    }
}
