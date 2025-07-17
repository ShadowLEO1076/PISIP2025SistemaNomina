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
    public class ContratosRepoImpl : RepositorioImpl<Contratos>, IContratosRepo
    {
        NominaPISIBContext _context;
        public ContratosRepoImpl(NominaPISIBContext context) : base(context)
        {
            this._context = context;
        }
        public async Task<List<Contratos>> GetAll()
        {
            try
            {

                var contratos =
                    _context.Contratos.ToListAsync();

                return await contratos;
            }
            catch (Exception ex) { throw new Exception("Error -  ContratosRepoImpl : No se pudo traer los datos. " + ex.Message); }
        }


    }
    
}
