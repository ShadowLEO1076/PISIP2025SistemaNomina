using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NominaPISIB.Aplicacion.DTO.DTOs;
using NominaPISIB.Dominio.Modelos.Abstracciones;
namespace NominaPISIB.Infraestructura.AccesoDatos.Repositorio
{
    public class InasistenciasRepoImpl : RepositorioImpl<Inasistencias>, IInasistenciasRepo
    {
        public InasistenciasRepoImpl(NominaPISIBContext context) : base(context)
        {
        }

        public Task<List<InasistenciasEmpleadosDTO>> ObtenerAsistenciasEmpleadoPorAnioYMes(string name, string lastname, int year, int month)
        {
            throw new NotImplementedException();
        }
    }
    
}
