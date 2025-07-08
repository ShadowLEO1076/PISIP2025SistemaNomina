using NominaPISIB.Aplicacion.DTO.DTOs;
using NominaPISIB.Dominio.Modelos.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NominaPISIB.Infraestructura.AccesoDatos.Repositorio
{
    public class ContratosRepoImpl : RepositorioImpl<Contratos>, IContratosRepo
    {
        NominaPISIBContext _context;
        public ContratosRepoImpl(NominaPISIBContext context) : base(context)
        {
            this._context = context;
        }
    }
    
}
