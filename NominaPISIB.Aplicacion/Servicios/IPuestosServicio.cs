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
    public interface IPuestosServicio : IService<Puestos> 
    {
        [OperationContract]
        Task<List<Puestos>> GetAll();
        /*
        
        [OperationContract]
        Task<bool> RegistrarPuestoAsync(string nombrePuesto, string descripcion, decimal salarioBase);
        [OperationContract]
        Task<bool> ActualizarPuestoAsync(int puestoId, string nuevoNombrePuesto, string nuevaDescripcion, decimal nuevoSalarioBase);
        [OperationContract]
        Task<bool> EliminarPuestoAsync(int puestoId);
        [OperationContract]
        Task<IEnumerable<string>> ObtenerPuestosAsync();
        [OperationContract]
        Task<string> ObtenerDetallesPuestoAsync(int puestoId);

        [OperationContract]
        Task<bool> NotificarPuestoRegistradoAsync(int puestoId, string mensajeNotificacion);

        [OperationContract]
        Task<bool> NotificarPuestoActualizadoAsync(int puestoId, string mensajeNotificacion);

        [OperationContract]
        Task<bool> NotificarPuestoEliminadoAsync(int puestoId, string mensajeNotificacion);
        */
    }
}
