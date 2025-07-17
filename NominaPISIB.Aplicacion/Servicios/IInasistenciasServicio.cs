using NominaPISIB.Aplicacion.DTO.DTOs;
using NominaPISIB.Infraestructura.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace NominaPISIB.Aplicacion.Servicios
{
    [ServiceContract]
    public interface IInasistenciasServicio : IService<Inasistencias>
    {
       [OperationContract]
       public Task<List<InasistenciasEmpleadosDTO>> ObtenerInasistenciasEmpleadoPorAnioYMes(string name, string lastname, int year, int month);

        [OperationContract]
        public int ContabilizarInasistencias(List<InasistenciasEmpleadosDTO> lista);
    }
}
