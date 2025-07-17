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
    public class DescuentosServicioImpl : ServicioImpl<Descuentos>, IDescuentosServicio
    {
        private IDescuentosRepo _descuentosRepo;
        public DescuentosServicioImpl(NominaPISIBContext context) : base(context)
        {
            this._descuentosRepo = new DescuentosRepoImpl(context);
        }

        public async Task<List<DescuentosEmpleadosDTO>> ObtenerDescuentosDeEmpleadoPorAnioYMes(string name, string lastname, int year, int month)
        {
            try
            {
                return await _descuentosRepo.ObtenerDescuentosDeEmpleadoPorAnioYMes(name, lastname, year, month);
            }
            catch (Exception ex)
            {
                throw new Exception("Error - DescuentosServicioImpl : Error al traer los datos. " + ex.Message);
            }
        }



        public decimal CalcularDescuentosDeEmpleadoPorAnioYMes(List<DescuentosEmpleadosDTO> lista)
        {
            decimal totalValor = 0;

            foreach (DescuentosEmpleadosDTO empleado in lista)
            {
                foreach (DescuentoDTO desc in empleado.Descuentos)
                {
                    totalValor = desc.descuentoMonto + totalValor;
                }
            }

            return totalValor;
        }
    
    }
}
