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
    public class AsistenciasRepoImpl : RepositorioImpl<Asistencias>, IAsistenciasRepo
    {
        private readonly NominaPISIBContext _context;
        public AsistenciasRepoImpl(NominaPISIBContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<List<AsistenciasEmpleadosDTO>> ObtenerAsistenciasEmpleadoPorAnioYMes(string name, string lastname, int year, int month)
        {
            try
            {
                var asistenciaActual = _context.Asistencias.Include(a => a.FKidEmpleadoNavigation)
                    .Where(a => a.FKidEmpleadoNavigation.EmpleadoNombres == name && a.FKidEmpleadoNavigation.EmpleadoApellidos == lastname &&
                    a.AsistenciaFecha.Year == year && a.AsistenciaFecha.Month == month).GroupBy(a => new
                    {
                        NombreCompleto = a.FKidEmpleadoNavigation.EmpleadoNombres + " " + a.FKidEmpleadoNavigation.EmpleadoApellidos
                    })
                    .Select(g => new AsistenciasEmpleadosDTO
                    {
                        NombresCompletos = g.Key.NombreCompleto,
                        Asistencias = g.Select(a => new AsistenciaDTO { AsistenciaDTOFecha = a.AsistenciaFecha }).ToList()
                    }
                    ).ToListAsync();

                return await asistenciaActual;
            }
            catch (Exception ex) { throw new Exception("Error - AsistenciasRepoImpl: no se puede obtener el dato" + ex.Message); }
        }
    }
}
