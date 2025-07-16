using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using NominaPISIB.Aplicacion.DTO.DTOs;
using NominaPISIB.Aplicacion.Servicios;
using NominaPISIB.Dominio.Modelos.Abstracciones;
using NominaPISIB.Infraestructura.AccesoDatos;
using NominaPISIB.Infraestructura.AccesoDatos.Repositorio;

namespace NominaPISIB.Aplicacion.ServiciosImpl
{
    public class EmpleadosServicioImpl : ServicioImpl<Empleados>, IEmpleadosServicio
    {
        private IEmpleadosRepo _repo;
        private readonly NominaPISIBContext _context;

        public EmpleadosServicioImpl(NominaPISIBContext context) : base(context)
        {
            _context = context;
            _repo = new EmpleadosRepoImpl(context);
        }
        public Task<List<BonificacionesEmpleadoDTO>> ObtenerBonificacionesDeEmpleadoPorAnio(string name, string lastname, int year)
        {
            return _repo.ObtenerBonificacionesDeEmpleadoPorAnio(name, lastname, year);
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
        // para reporte inacistencias licencia dto
        public async Task<List<ReporteEmpleadosInasistenciasLicenciaDTO>> ObtenerReporteEmpleadosInasistenciasLicencia(int mes, int anio)
        {
            return await _repo.ObtenerReporteEmpleadosInasistenciasLicencia(mes, anio);
        }


        public async Task<List<ReporteDescuentosNominaDTO>> ObtenerReporteDescuentosMensual(int mes, int anio)
        {
            return await _repo.ObtenerReporteDescuentosMensual(mes, anio);
        }

        public async Task<List<Empleados>> ObtenerEmpleadosActivos()
        {
            return await _repo.ObtenerEmpleadosActivos();
        }

        public async Task<Empleados> ObtenerEmpleadoPorNombre(string name, string lastname)
        {
            return await _repo.ObtenerEmpleadoPorNombre(name, lastname);
        }

        /* Inutilizado, mandado a DescuestosServicioImpl
        public async Task<List<DescuentosEmpleadosDTO>> ObtenerDescuentosDeEmpleadoPorAnioYMes(string name, string lastname, int year, int month)
        {
           return await _repo.ObtenerDescuentosDeEmpleadoPorAnioYMes(name, lastname, year, month);
        }*/

        public decimal CalcularBonificacionesDeEmpleadoPorAnioYMesAsync(List<BonificacionesEmpleadoDTO> lista)
        {
            decimal totalValor = 0;

            foreach(BonificacionesEmpleadoDTO empleado in lista) 
            {
                foreach(BonificacionesDTO boni in empleado.bonificaciones)
                {
                    totalValor = boni.BonificacionMonto + totalValor;
                }
            }

            return totalValor;
        }

        public decimal CalcularDescuentosDeEmpleadoPorAnioYMes(List<DescuentosEmpleadosDTO> lista)
        {
            decimal totalValor = 0;

            foreach (DescuentosEmpleadosDTO empleado in lista)
            {
                foreach (DescuentoDTO desc in empleado.Descuentos)
                {
                    totalValor = desc.descuentoMonto + totalValor;
                }
            }

            return totalValor;
        }
    }

}  


