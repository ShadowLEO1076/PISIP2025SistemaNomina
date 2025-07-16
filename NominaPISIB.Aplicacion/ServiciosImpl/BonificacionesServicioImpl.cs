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
    public class BonificacionesServicioImpl : ServicioImpl<Bonificaciones>, IBonificacionesServicio
    {
        private IBonificacionesRepo _bonificacionesServicio;
        public BonificacionesServicioImpl(NominaPISIBContext context) : base(context)
        {
            this._bonificacionesServicio = new BonificacionesRepoImpl(context);
        }

        public async Task<List<BonificacionesEmpleadoDTO>> ObtenerBonificacionesDeEmpleadoPorAnioYMes(string name, string lastname, int year, int month)
        {
            try 
            {
                return await _bonificacionesServicio.ObtenerBonificacionesDeEmpleadoPorAnioYMes(name, lastname, year, month);
            }
            catch(Exception ex)
            {
                throw new Exception("Error - BonificacionesServicioImpl : error al hallar los datos. " + ex.Message);
            }
        }

        public decimal CalcularBonificacionesDeEmpleadoPorAnioYMesAsync(List<BonificacionesEmpleadoDTO> lista)
        {
            decimal totalValor = 0;

            foreach (BonificacionesEmpleadoDTO empleado in lista)
            {
                foreach (BonificacionesDTO boni in empleado.bonificaciones)
                {
                    totalValor = boni.BonificacionMonto + totalValor;
                }
            }

            return totalValor;
        }
    }
}
