using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NominaPISIB.Aplicacion.DTO.DTOs;
using NominaPISIB.Aplicacion.Servicios;
using NominaPISIB.Dominio.Modelos.Abstracciones;
using NominaPISIB.Infraestructura.AccesoDatos;
using NominaPISIB.Infraestructura.AccesoDatos.Repositorio;

namespace NominaPISIB.Aplicacion.ServiciosImpl
{
    public class InasistenciasServicioImpl : ServicioImpl<Inasistencias>, IInasistenciasServicio
    {
        private IInasistenciasRepo _repo;
        private readonly NominaPISIBContext _context;
        public InasistenciasServicioImpl(NominaPISIBContext context) : base(context)
        {
            _context = context;
            _repo = new InasistenciasRepoImpl(context);

        }

        public async Task<List<InasistenciasEmpleadosDTO>> ObtenerInasistenciasEmpleadoPorAnioYMes(string name, string lastname, int year, int month)
        {
            try
            {
                return await _repo.ObtenerInasistenciasEmpleadoPorAnioYMes(name, lastname, year, month);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error - InasistenciasServicioImpl : no se puede traer los datos. {ex.Message}");
            }
        }

        public int ContabilizarInasistencias(List<InasistenciasEmpleadosDTO> lista)
        {
            int total = 0;

            foreach (InasistenciasEmpleadosDTO empleado in lista)
            {
                foreach (InasistenciaDTO inasistencia in empleado.Inasistencias)
                {
                    total += 1;
                }
            }

            return total;
        }

        public int ContabilizarInasistenciasRemunerables(List<InasistenciasEmpleadosDTO> lista)
        {
            int total = 0;

            foreach (InasistenciasEmpleadosDTO empleado in lista)
            {
                foreach (InasistenciaDTO inasistencia in empleado.Inasistencias)
                {
                    if(inasistencia.LicenciaRemunerable == 1)
                        total += 1; 
                }
            }

            return total;
        }

        public int ContabilizarInasistenciasNoRemunerables(List<InasistenciasEmpleadosDTO> lista)
        {
            throw new NotImplementedException();
        }
    }
}
