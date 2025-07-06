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
        public Task<List<EmpleadosContratoActivoDTO>> ObtenerContratoActivoEmpleados();

<<<<<<< HEAD
        public Task<List<HistorialContratoEmpleados>> ObtenerHistorialPorEmpleado(string nameEmpl, string lastnameEmpl);
=======
        // aqui voy agregregar lo de arriba pero enfocado para ReporteNominaMensualDTO

        public Task<List<ReporteNominaMensualDTO>> ObtenerReporteNominaMensual(int mes, int anio);

>>>>>>> 32a573b7c3e097180a9624f5b756580afac25ef2
    }
}
