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

        public async Task<List<DescuentosEmpleadosDTO>> ObtenerDescuentosDeEmpleadoPorAnio(string name, string lastname, int year)
        {
            try
            {
                var fecha = year;

                var empleados =
                    _context.Empleados.Where(emp => emp.EmpleadoNombres == name && emp.EmpleadoApellidos == lastname)
                    .Select(dto => new DescuentosEmpleadosDTO
                    {
                        NombresCompletos = dto.EmpleadoNombres + dto.EmpleadoApellidos,
                        boniYear = fecha,

                        Descuentos = dto.Descuentos.Where(d => (d.DescuentoFecha.Year == fecha)).Select(d => new DescuentoDTO
                        {
                            descuentoFecha = d.DescuentoFecha,
                            descuentoMonto = d.DescuentoMonto,
                        }).ToList()
                    }).Where(bonoAux => bonoAux.Descuentos.Any()).ToListAsync();

                return await empleados;
            }
            catch (Exception ex) { throw new Exception("Error - EmpleadosRepoImpl : No se pudo traer los datos. " + ex.Message); }
        }

        public async Task<List<BonificacionesEmpleadoDTO>> ObtenerBonificacionesDeEmpleadoPorAnio(string name, string lastname, int year)
        {
            try
            { 
                var fecha = year;

                var empleadosConContratoActual =
                    _context.Empleados.Where(emp => emp.EmpleadoNombres == name && emp.EmpleadoApellidos == lastname)
                    .Select(dto => new BonificacionesEmpleadoDTO
                    {
                        NombresCompletos = dto.EmpleadoNombres + dto.EmpleadoApellidos,
                        boniYear = fecha,

                        bonificaciones = dto.Bonificaciones.Where(b => (b.BonificacionFecha.Year == fecha)).Select(b => new BonificacionesDTO
                        {
                            BonificacionFecha = b.BonificacionFecha,
                            BonificacionMonto = b.BonificacionMonto,
                        }).ToList()
                    }).Where(bonoAux => bonoAux.bonificaciones.Any()).ToListAsync();

                return await empleadosConContratoActual;
            }
            catch (Exception ex) { throw new Exception("Error - EmpleadosRepoImpl : No se pudo traer los datos. " + ex.Message); }
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
                         NombresCompletos = e.EmpleadoNombres + " " + e.EmpleadoApellidos,
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

            public async Task<List<ReporteDescuentosNominaDTO>> ObtenerReporteDescuentosMensual(int mes, int anio)
            {

        }    
        public async Task<List<ReporteDescuentosNominaDTO>> ObtenerReporteDescuentosMensual(int mes, int anio)
        {


            
            try
            {
               var ReporteL2 =
                   _context.Empleados.Where(Rdesc => (Rdesc.EmpleadoFechaIngreso.Month == mes) && (Rdesc.EmpleadoFechaIngreso.Year == anio))
                   .Select(e => new ReporteDescuentosNominaDTO // 
                   {
                       NombresCompletos = e.EmpleadoNombres + " " + e.EmpleadoApellidos,
                       IdEmpleado = e.idEmpleado,
                       Anio = anio,
                       Mes = mes,
                       TotalDescuentos = e.Descuentos
                                .Where(d => (d.DescuentoFecha.Month == mes) && (d.DescuentoFecha.Year == anio))
                                .Select(d => d.DescuentoMonto)
                                .Sum(),
                       TotalDescuentosEmpleado = e.Nominas
                                .Where(n => (n.NominaMes == mes) && (n.NominaAnio == anio))
                                .Select(n => n.NominaDescuentos)
                                .Sum(),

                       FechaEmision = e.Nominas
                                .Where(n => (n.NominaFechaEmision.Month == mes) && (n.NominaFechaEmision.Year == anio))
                                .Select(n => n.NominaFechaEmision)
                                .FirstOrDefault(),
                       SalarioBase = e.Nominas
                                .Where(n => (n.NominaFechaEmision.Month == mes) && (n.NominaFechaEmision.Year == anio))
                                .Select(n => n.NominaSalarioBase)
                                .FirstOrDefault(),
                       SueldoNeto = e.Nominas
                                .Where(n => (n.NominaFechaEmision.Month == mes) && (n.NominaFechaEmision.Year == anio))
                                .Select(n => n.NominaSalarioNeto)
                                .FirstOrDefault(),
                       EstadoContrato = e.Contratos
                                .Where(c => (c.FechaInicioContrato.Month == mes) && (c.FechaInicioContrato.Year == anio))
                                .Select(c => c.EstadoContrato)
                                .FirstOrDefault(),

                       DescripcionDescuentos = e.Descuentos
                                .Where(d => (d.DescuentoFecha.Month == mes) && (d.DescuentoFecha.Year == anio))
                                .Select(d => d.DescuentoDescripcion)
                                .ToList(),

                       MontoDescuentos = e.Descuentos
                                .Where(d => (d.DescuentoFecha.Month == mes) && (d.DescuentoFecha.Year == anio))
                                .Select(d => d.DescuentoMonto)
                                .ToList(),


                   }).ToListAsync(); return await ReporteL2;

            }


        


           

        // para reporte nomina mensual dto



            catch
            {
               throw new NotImplementedException("no funciona el test leo nomina reporte mensual");
            }
        }
        public Task<List<ReporteEmpleadosInasistenciasLicenciaDTO>> ObtenerReporteEmpleadosInasistenciasLicencia(int mes, int anio)
        {
            try
            {
                var ReporteL3 = _context.Empleados
                    .Select(e => new ReporteEmpleadosInasistenciasLicenciaDTO
                    {
                        NombresCompletos = e.EmpleadoNombres + " " + e.EmpleadoApellidos,
                        IdEmpleado = e.idEmpleado,
                        NumeroIdentidad = e.EmpleadoCedula,

                        FechaInasistencia = e.Inasistencias
                            .Where(i => i.InasistenciaFecha.Month == mes && i.InasistenciaFecha.Year == anio)
                            .Select(i => i.InasistenciaFecha)
                            .FirstOrDefault(),
                        IdLicencia = e.Inasistencias
                            .Where(i => i.InasistenciaFecha.Month == mes && i.InasistenciaFecha.Year == anio)
                            .Select(i => i.idLicencia)
                            .FirstOrDefault(),



                    })
                    .ToListAsync();

                return ReporteL3;
            }
            catch
            {
                throw new NotImplementedException("no funciona el test leo nomina reporte mensual");
            }
        }
        // para reporte nomina mensual dto

        public async Task<List<ReporteNominaMensualDTO>> ObtenerReporteNominaMensual(int mes, int anio)
        {
            try
            {
                var ReporteL1 =
                    _context.Empleados.Where(Rnomi => (Rnomi.EmpleadoFechaIngreso.Month == mes) && (Rnomi.EmpleadoFechaIngreso.Year == anio))
                    .Select(e => new ReporteNominaMensualDTO
                    {
          
                        NombresEmpleados = e.EmpleadoNombres + " " + e.EmpleadoApellidos,
                        IdEmpleado = e.idEmpleado,

                        Anio = anio,
                        Mes = mes,
                        
                        TotalHorasExtras = e.Nominas
                            .Where(n => (n.NominaFechaEmision.Month == mes) && (n.NominaFechaEmision.Year == anio))
                            .Select(n => n.NominaHorasExtra)
                            .FirstOrDefault(),

                        TotalBonificaciones = e.Nominas
                            .Where(n => (n.NominaFechaEmision.Month == mes) && (n.NominaFechaEmision.Year == anio))
                            .Select(n => n.NominaBonificaciones)
                            .FirstOrDefault(),

                        TotalBonificacionesEmpleado = e.Bonificaciones
                            .Where(b => (b.BonificacionFecha.Month == mes) && (b.BonificacionFecha.Year == anio))
                            .Select(b => b.BonificacionMonto)
                            .Sum(),
                        TotalDescuentos = e.Descuentos
                            .Where(d => (d.DescuentoFecha.Month == mes) && (d.DescuentoFecha.Year == anio))
                            .Select(d => d.DescuentoMonto)
                            .Sum(),

                        TotalDescuentosEmpleado = e.Descuentos
                            .Where(d => (d.DescuentoFecha.Month == mes) && (d.DescuentoFecha.Year == anio))
                            .Select(d => d.DescuentoMonto)
                            .Sum(),

                        SalarioBase = e.Nominas
                            .Where(n =>( n.NominaFechaEmision.Month == mes) && (n.NominaFechaEmision.Year == anio))
                            .Select(n => n.NominaSalarioNeto)
                            .FirstOrDefault(),
                        
                        FechaEmision = e.Nominas
                            .Where(n => (n.NominaFechaEmision.Month == mes) && (n.NominaFechaEmision.Year == anio))
                            .Select(n => n.NominaFechaEmision)
                            .FirstOrDefault(),

                        SalarioNeto = e.Nominas
                            .Where(n => (n.NominaFechaEmision.Month == mes) && (n.NominaFechaEmision.Year == anio))
                            .Select(n => n.NominaSalarioNeto)
                            .FirstOrDefault(),

                        EstadoContrato = e.Contratos
                            .Where(c => (c.FechaInicioContrato.Month == mes) && (c.FechaInicioContrato.Year == anio))
                            .Select(c => c.EstadoContrato)
                            .FirstOrDefault(),
                    }).ToListAsync();return await ReporteL1;
            }
            catch
            {
                throw new NotImplementedException("no funciona el test leo nomina reporte mensual");
            }    
        }

        public async Task<List<Empleados>> ObtenerEmpleadosActivos()
        {
            try 
            {
                var recuperados =
                    _context.Empleados.Where(e => e.EmpleadoEstado == "1" | e.EmpleadoEstado == "Activo").ToListAsync();
                return await recuperados;
            }
            catch(Exception ex) { throw new Exception("Error - EmpleadosRepoImpl: no se pudo traer los datos"
                + ex.Message); }
        }
    }
}
