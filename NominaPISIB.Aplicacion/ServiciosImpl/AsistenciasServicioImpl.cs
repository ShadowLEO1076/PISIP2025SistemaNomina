using NominaPISIB.Aplicacion.DTO.DTOs;
using NominaPISIB.Aplicacion.Servicios;
using NominaPISIB.Dominio.Modelos.Abstracciones;
using NominaPISIB.Infraestructura.AccesoDatos;
using NominaPISIB.Infraestructura.AccesoDatos.Repositorio;
using System;
using System.Collections;
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
            try
            {
                return await _repo.ObtenerAsistenciasEmpleadoPorAnioYMes(name, lastname, year, month);
            }
            catch (Exception ex) {
                throw new Exception("Error - AsistenciasServicioImpl : no se pudo obtener los datos");
            }
        }

        public int ContabilizarAsistencias(List<AsistenciasEmpleadosDTO> lista)
        {
            int total = 0;

            foreach (AsistenciasEmpleadosDTO empleado in lista)
            {
                foreach (AsistenciaDTO asistencia in empleado.Asistencias)
                {
                    total += 1;
                }
            }

            return total;
        }

    }
}
