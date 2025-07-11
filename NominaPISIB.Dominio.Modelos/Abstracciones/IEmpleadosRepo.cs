﻿using System;
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
        public Task<List<Empleados>> ObtenerEmpleadosActivos();
        public Task<List<EmpleadosContratoActivoDTO>> ObtenerContratoActivoEmpleados();
        public Task<List<DescuentosEmpleadosDTO>> ObtenerDescuentosDeEmpleadoPorAnio(string name, string lastname, int year);
        public Task<List<BonificacionesEmpleadoDTO>> ObtenerBonificacionesDeEmpleadoPorAnio(string name, string lastname, int year);
        public Task<List<HistorialContratoEmpleados>> ObtenerHistorialPorEmpleado(string nameEmpl, string lastnameEmpl);

        // aqui voy agregregar lo de arriba pero enfocado para ReporteNominaMensualDTO

        public Task<List<ReporteNominaMensualDTO>> ObtenerReporteNominaMensual(int mes, int anio);

        // para reporte nomina mensual dto
        public Task<List<ReporteDescuentosNominaDTO>> ObtenerReporteDescuentosMensual(int mes, int anio);

        // para ReporteEmpleadosInasistenciasLicenciaDTO

        public Task<List<ReporteEmpleadosInasistenciasLicenciaDTO>> ObtenerReporteEmpleadosInasistenciasLicencia(int mes, int anio);







    }
}
