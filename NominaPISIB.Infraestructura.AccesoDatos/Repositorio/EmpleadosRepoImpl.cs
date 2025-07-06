using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NominaPISIB.Aplicacion.DTO.DTOs;
using NominaPISIB.Dominio.Modelos.Abstracciones;
namespace NominaPISIB.Infraestructura.AccesoDatos.Repositorio
{
    public class EmpleadosRepoImpl : RepositorioImpl<Empleados>, IEmpleadosRepo
    {
        private readonly NominaPISIBContext _context;
        public EmpleadosRepoImpl(NominaPISIBContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<List<EmpleadosContratoActivoDTO>> ObtenerContratoActivoEmpleados()
        {
            try
            {
                var hoy = DateOnly.FromDateTime(DateTime.Today);

                var empleadosConContratoActual =
                    _context.Empleados.Where(emp => emp.EmpleadoEstado == "1" | emp.EmpleadoEstado == "Activo")
                    .Select(e => new EmpleadosContratoActivoDTO
                        {
                         NombresCompletos = e.EmpleadoNombres + " " +e.EmpleadoApellidos,
                         Correo = e.EmpleadoCorreo,
                         Genero = e.EmpleadoGenero,
                         FechaIngreso = e.EmpleadoFechaIngreso,
                         Telefono = e.EmpleadoTelfPersonal,


                         FechaInicioContrato = e.Contratos
                        .Where(c => c.FechaInicioContrato <= hoy && c.ContratoFechaFin >= hoy)
                        .OrderByDescending(c => c.FechaInicioContrato)
                        .Select(c => c.FechaInicioContrato)
                        .FirstOrDefault(),

                         FechaFinContrato = e.Contratos
                        .Where(c => c.FechaInicioContrato <= hoy && c.ContratoFechaFin >= hoy)
                        .OrderByDescending(c => c.FechaInicioContrato)
                        .Select(c => c.ContratoFechaFin)
                        .FirstOrDefault(),

                         Salario = e.Contratos
                        .Where(c => c.FechaInicioContrato <= hoy && c.ContratoFechaFin >= hoy)
                        .OrderByDescending(c => c.FechaInicioContrato)
                        .Select(c => c.ContratoSalario)
                        .FirstOrDefault()
                    })
                    .ToListAsync();

                return await empleadosConContratoActual;
            }
            catch (Exception ex) { throw new Exception("Error - EmpleadosRepoImpl : No se pudo traer los datos. " + ex.Message); }
        }

        public async Task<List<HistorialContratoEmpleados>> ObtenerHistorialPorEmpleado(string nameEmpl, string lastnameEmpl)
        {
            try

            {
                var historial = _context.Empleados
                                .Where(emp => emp.EmpleadoNombres == nameEmpl && emp.EmpleadoApellidos == lastnameEmpl)
                                 .Select(empl => new HistorialContratoEmpleados
                                 {
                                     NombresCompletos = empl.EmpleadoNombres + " " + empl.EmpleadoApellidos,
                                     FechaIngreso = empl.EmpleadoFechaIngreso,

                                     ContratosEmpleado = empl.Contratos.Select(c => new ContratoDto
                                     {
                                         idContrato = c.idContrato,
                                         FechaInicioContrato = c.FechaInicioContrato,
                                         ContratoFechaFin = c.ContratoFechaFin,
                                         ContratoSalario = c.ContratoSalario
                                     }).ToList()
                                 }).ToListAsync();
                                       
                return await historial;
            }
            catch (Exception ex) { throw new Exception("Error - EmpleadosRepoImpl : No se pudo traer los datos. " + ex.Message); }
        }

        public Task<List<ReporteNominaMensualDTO>> ObtenerReporteNominaMensual(int mes, int anio)
        {
            throw new NotImplementedException();
        }
    }
}
