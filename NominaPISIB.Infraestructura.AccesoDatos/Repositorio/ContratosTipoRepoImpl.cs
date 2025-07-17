using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NominaPISIB.Dominio.Modelos.Abstracciones;
namespace NominaPISIB.Infraestructura.AccesoDatos.Repositorio
{
    public class ContratosTipoRepoImpl : RepositorioImpl<ContratosTipo>, IContratosTipoRepo
    {
        NominaPISIBContext _context;
        public ContratosTipoRepoImpl(NominaPISIBContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<List<ContratosTipo>> GetAll()
        {
            try
            {

                var contratostipo =
                    _context.ContratosTipo.ToListAsync();

                return await contratostipo;
            }
            catch (Exception ex) { throw new Exception("Error -  ContratosRepoImpl : No se pudo traer los datos. " + ex.Message); }
        }
    }
}
