using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NominaPISIB.Dominio.Modelos.Abstracciones;
namespace NominaPISIB.Infraestructura.AccesoDatos.Repositorio
{
    public class PuestosRepoImpl : RepositorioImpl<Puestos>, IPuestosRepo
    {
        public PuestosRepoImpl(NominaPISIBContext context) : base(context)
        {
        }
    }
    
}
