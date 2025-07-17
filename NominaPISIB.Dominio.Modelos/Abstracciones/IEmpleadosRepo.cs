using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NominaPISIB.Infraestructura.AccesoDatos;
using NominaPISIB.Aplicacion.DTO.DTOs;

namespace NominaPISIB.Dominio.Modelos.Abstracciones
{
    public interface IEmpleadosRepo : IRepository<Empleados>
    {

        // Nos permitirá traer un entidad del tipo empleado por nombre.
        public Task<Empleados> ObtenerEmpleadoPorNombre(string name, string lastname);

        // Permite ver los empleados con estado Activo en la base de datos. -> Mateo Vasquez
        public Task<List<Empleados>> ObtenerEmpleadosActivos();

        // Permite ver el contrato activo del empleado. Pues un empleado puede tener múltiples contratos en realidad. -> Mateo Vasquez
        public Task<List<EmpleadosContratoActivoDTO>> ObtenerContratoActivoEmpleados();

        // Permite ver los descuentos del empleado a lo largo de un año específico. -> Mateo Vasquez
        public Task<List<DescuentosEmpleadosDTO>> ObtenerDescuentosDeEmpleadoPorAnio(string name, string lastname, int year);

        /* Inutilizada, movida a DescuentosRepo, tanto Interfaz como servicio
        //Hace lo que dice, después de este necesitamos crear un método que permita contar el total -> Mateo Vasquez
        public Task<List<DescuentosEmpleadosDTO>> ObtenerDescuentosDeEmpleadoPorAnioYMes(string name, string lastname, int year, int month);
        */

        // Permite ver las bonificaciones del empleado a lo largo de un año específico. -> Mateo Vasquez
        public Task<List<BonificacionesEmpleadoDTO>> ObtenerBonificacionesDeEmpleadoPorAnio(string name, string lastname, int year);

        //Hace lo que dice, después de este necesitamos crear un método que permita contar el total, eso debe hacerse en servicio -> Mateo Vasquez

        // Permite ver el historial de contratos del empleado. -> Mateo Vasquez
        public Task<List<HistorialContratoEmpleados>> ObtenerHistorialPorEmpleado(string nameEmpl, string lastnameEmpl);

        // aqui voy agregregar lo de arriba pero enfocado para ReporteNominaMensualDTO

        //public Task<List<ReporteNominaMensualDTO>> ObtenerReporteNominaMensual(int mes, int anio);

        // para reporte nomina mensual dto
       // public Task<List<ReporteDescuentosNominaDTO>> ObtenerReporteDescuentosMensual(int mes, int anio);

        // para ReporteEmpleadosInasistenciasLicenciaDTO

        public Task<List<ReporteEmpleadosInasistenciasLicenciaDTO>> ObtenerReporteEmpleadosInasistenciasLicencia(int mes, int anio);







    }
}
