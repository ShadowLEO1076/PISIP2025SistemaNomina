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
    public class DescuentosRepoImpl : RepositorioImpl<Descuentos>, IDescuentosRepo
    {
        private readonly NominaPISIBContext _context;
        public DescuentosRepoImpl(NominaPISIBContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<List<DescuentosEmpleadosDTO>> ObtenerDescuentosDeEmpleadoPorAnioYMes(string name, string lastname, int year, int month)
        {
            try 
            {
                var descuentos =
                    _context.Descuentos.Include(d => d.idEmpleadoNavigation)
                    .Where(d => d.idEmpleadoNavigation.EmpleadoNombres == name && d.idEmpleadoNavigation.EmpleadoApellidos == lastname
                    && d.DescuentoFecha.Year == year && d.DescuentoFecha.Month == month).GroupBy(d => new
                    {
                        NombreCompleto = d.idEmpleadoNavigation.EmpleadoNombres + " " + d.idEmpleadoNavigation.EmpleadoApellidos
                    }).Select(g => new DescuentosEmpleadosDTO
                    {
                        NombresCompletos = g.Key.NombreCompleto,
                        boniYear = year,
                        Descuentos = g.Select(d => new DescuentoDTO
                        {
                            descuentoFecha = d.DescuentoFecha,
                            descuentoMonto =d.DescuentoMonto
                        }).ToList()
                    }).ToListAsync();

                return await descuentos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error - DescuestosRepoImpl : error al hallar los datos. " + ex.Message);
            }
        }
    }
    
}
