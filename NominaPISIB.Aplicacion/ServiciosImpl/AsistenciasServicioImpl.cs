using NominaPISIB.Aplicacion.DTO.DTOs;
using NominaPISIB.Aplicacion.Servicios;
using NominaPISIB.Dominio.Modelos.Abstracciones;
using NominaPISIB.Infraestructura.AccesoDatos;
using NominaPISIB.Infraestructura.AccesoDatos.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaPISIB.Aplicacion.ServiciosImpl
{
    public class AsistenciasServicioImpl : ServicioImpl<Asistencias>, IAsistenciasServicio
    {
        private IAsistenciasRepo _repo;

        public AsistenciasServicioImpl(NominaPISIBContext context) : base(context)
        {
            this._repo = new AsistenciasRepoImpl(context);
        }
     
        public async Task<List<AsistenciasEmpleadosDTO>> ObtenerAsistenciasEmpleadoPorAnioYMes(string name, string lastname, int year, int month)
        {
            return await _repo.ObtenerAsistenciasEmpleadoPorAnioYMes(name, lastname, year, month);
        }

    }
}
