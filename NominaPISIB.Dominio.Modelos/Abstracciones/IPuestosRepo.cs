using NominaPISIB.Infraestructura.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaPISIB.Dominio.Modelos.Abstracciones
{
    public interface IPuestosRepo : IRepository<Puestos>
    {
        // devuelve una lista de todos los puestos, ideal para insertar en otros lados. -> Mateo
        Task<List<Puestos>> GetAll();

        Task<Puestos> ObtenerPuestoPorNombre(string nombre);
    }
}
