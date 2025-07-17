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
    public class InasistenciasRepoImpl : RepositorioImpl<Inasistencias>, IInasistenciasRepo
    {
        private readonly NominaPISIBContext _context;
        public InasistenciasRepoImpl(NominaPISIBContext context) : base(context)
        {
            this._context  = context;  
        }
        
        public async Task<List<InasistenciasEmpleadosDTO>> ObtenerInasistenciasEmpleadoPorAnioYMes(string name, string lastname, int year, int month)
        {
            try
            {
               return await
                    _context.Inasistencias.Include(i => i.idEmpleadoNavigation).Include(i => i.idLicenciaNavigation)
                    .Where(i => i.idEmpleadoNavigation.EmpleadoNombres == name && i.idEmpleadoNavigation.EmpleadoApellidos == lastname
                    && i.InasistenciaFecha.Year == year && i.InasistenciaFecha.Month == month)
                    .GroupBy(i => new
                    {
                        NombreCompleto = i.idEmpleadoNavigation.EmpleadoNombres + " " + i.idEmpleadoNavigation.EmpleadoApellidos
                    }).Select(g =>  new InasistenciasEmpleadosDTO
                    {
                        NombresCompletos = g.Key.NombreCompleto,
                        Inasistencias = g.Select(i => new InasistenciaDTO
                        {
                            LicenciaNombre = i.idLicenciaNavigation.LicenciaNombre,
                            LicenciaRemunerable = i.idLicenciaNavigation.LicenciaRemunerable,
                            InasistenciaFecha = i.InasistenciaFecha

                        }).ToList()
                    }).ToListAsync();

            }
            catch (Exception ex) 
            {
                throw new Exception("Error - InasistenciasRepoImple : no se pudo traer los datos");
            }
        }
        
    }
    
}
