using NominaPISIB.Infraestructura.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NominaPISIB.Dominio.Modelos.Abstracciones
{
    public interface IContratosRepo : IRepository<Contratos>
    {
        Task<List<Contratos>> GetAll();
    }
}
