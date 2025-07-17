using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NominaPISIB.Aplicacion.DTO.DTOs;
using NominaPISIB.Dominio.Modelos.Abstracciones;
namespace NominaPISIB.Infraestructura.AccesoDatos.Repositorio
{
    public class BonificacionesRepoImpl : RepositorioImpl<Bonificaciones>, IBonificacionesRepo
    {
        private readonly NominaPISIBContext _context;
        public BonificacionesRepoImpl(NominaPISIBContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<List<BonificacionesEmpleadoDTO>> ObtenerBonificacionesDeEmpleadoPorAnioYMes(string name, string lastname, int year, int month)
        {
            try 
            {
                return await
                   _context.Bonificaciones.Include(b => b.idEmpleadoNavigation)
                    .Where(b => b.idEmpleadoNavigation.EmpleadoNombres == name && b.idEmpleadoNavigation.EmpleadoApellidos == lastname &&
                    b.BonificacionFecha.Year == year && b.BonificacionFecha.Month == month).GroupBy(e => new
                    {
                        NombreCompleto = e.idEmpleadoNavigation.EmpleadoNombres + " " + e.idEmpleadoNavigation.EmpleadoApellidos
                    }).Select(g => new BonificacionesEmpleadoDTO
                    {
                        NombresCompletos = g.Key.NombreCompleto,
                        boniYear = year,
                        bonificaciones = g.Select(b => new BonificacionesDTO { 
                            BonificacionFecha  = b.BonificacionFecha,
                            BonificacionMonto = b.BonificacionMonto
                        }).ToList()
                    }).ToListAsync();

            }
            catch(Exception ex) { throw new Exception("Error - BonificacionesRepoImpl : no se pudo hallar los datos. " + ex.Message); }
        }
    }
}
