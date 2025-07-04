using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace NominaPISIB.Aplicacion.Servicios
{

    [ServiceContract]
    public interface IService<T> where T : class
    {
        [OperationContract]
        Task AddAsync(T entity); //Encargada de añadir una entidad en surespectiva tabla, usa el dato
                                         //Task por cosas de EF Core
        [OperationContract]
        Task UpdateAsync(T entity); //Encargada de actualizar un registro dentro de una tabla. A saber cómo lo logra

        [OperationContract]
        Task DeleteAsync(int id); //Encargada de eliminar un registro de la tabla siempre que se sepa su id.

        [OperationContract]
        Task<IEnumerable<T>> GetAllAsync(); //Encargada de traer todos los registros de la tabla.

        [OperationContract]
        Task<T> GetByIdAsync(int id); //Encargada de traer un registro de la tabla, este si es un Task<T>
                                              //ya que debe devolver la entidad del registro adecuado.
    }
}
