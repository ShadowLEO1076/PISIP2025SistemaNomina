using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using NominaPISIB.Infraestructura.AccesoDatos;

namespace NominaPISIB.Aplicacion.Servicios
{
    [ServiceContract]
    public interface IContratosServicio : IService<Contratos>
    {
        [OperationContract]
        public Task<List<Contratos>> GetAll(); // PUBLIC 
       

    }
}
