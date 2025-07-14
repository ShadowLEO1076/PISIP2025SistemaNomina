using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NominaPISIB.Aplicacion.DTO.DTOs;
using NominaPISIB.Infraestructura.AccesoDatos;

namespace NominaPISIB.Dominio.Modelos.Abstracciones
{
    public interface IAsistenciasRepo : IRepository<Asistencias>
    {

        Task<List<AsistenciasEmpleadosDTO>> ObtenerAsistenciasEmpleadoPorAnioYMes(string name, string lastname, int year, int month);
    }
}
