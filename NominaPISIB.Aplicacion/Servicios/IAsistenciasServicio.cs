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
    public interface IAsistenciasServicio : IService<Asistencias>
    {
        //hace lo que dice, con esto podremos hacer la nómina -> Mateo Vasquez
        [OperationContract]
        Task<List<AsistenciasEmpleadosDTO>> ObtenerAsistenciasEmpleadoPorAnioYMes(string name, string lastname, int year, int month);
        [OperationContract]
        public int ContabilizarAsistencias(List<AsistenciasEmpleadosDTO> lista);


    }
}
