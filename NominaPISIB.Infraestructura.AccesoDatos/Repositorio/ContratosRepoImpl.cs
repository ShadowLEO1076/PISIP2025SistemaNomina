using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NominaPISIB.Dominio.Modelos.Abstracciones;
namespace NominaPISIB.Infraestructura.AccesoDatos.Repositorio
{
    public class ContratosRepoImpl : RepositorioImpl<Contratos>, IContratosRepo
    {
        public ContratosRepoImpl(NominaPISIBContext context) : base(context)
        {
        }
    }
    
}
