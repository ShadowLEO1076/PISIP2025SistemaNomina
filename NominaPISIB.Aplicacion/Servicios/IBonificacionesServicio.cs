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
    public interface IBonificacionesServicio : IService<Bonificaciones>
    {
        [OperationContract]
<<<<<<< HEAD
        Task<List<BonificacionesEmpleadoDTO>> ObtenerBonificacionesDeEmpleadoPorAnioYMes(string name, string lastname, int year, int month);
        [OperationContract]
        decimal CalcularBonificacionesDeEmpleadoPorAnioYMes(List<BonificacionesEmpleadoDTO> lista);
=======
        Task<List<BonificacionesEmpleadoDTO>> ObtenerBonificacionesDeEmpleadoPorAnioYMes(string name, string lastname, int year, int month); // si no funciona es con BonificacionesEmpleadoDTO 
>>>>>>> 437c55fe5fc42416a02743bca2cb0611be6c3432

    }
}
