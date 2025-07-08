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
        Task<bool> RegistrarBonificacionAsync(int empleadoId, decimal monto, string descripcion);
        [OperationContract]
        Task<bool> ActualizarBonificacionAsync(int bonificacionId, decimal nuevoMonto, string nuevaDescripcion);
        [OperationContract]
        Task<bool> EliminarBonificacionAsync(int bonificacionId);
        [OperationContract]
        Task<IEnumerable<string>> ObtenerBonificacionesPorEmpleadoAsync(int empleadoId);

    }
}
