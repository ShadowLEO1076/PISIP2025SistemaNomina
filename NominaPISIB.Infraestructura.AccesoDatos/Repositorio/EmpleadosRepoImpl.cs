using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    _context.Empleados.Where(emp => emp.EmpleadoEstado == "1")
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
                    .ToList();

                return empleadosConContratoActual;
            }
            catch (Exception ex) { throw new Exception("Error - EmpleadosRepoImpl : No se pudo traer los datos. " + ex.Message); }
        }
    }
}
