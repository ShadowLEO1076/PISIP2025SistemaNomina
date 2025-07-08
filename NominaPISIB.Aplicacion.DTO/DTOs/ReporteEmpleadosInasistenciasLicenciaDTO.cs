using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaPISIB.Aplicacion.DTO.DTOs
{
    public class ReporteEmpleadosInasistenciasLicenciaDTO
    {
        // Datos del empleado

        public int IdEmpleado { get; set; } // Identificador del empleado
        public string NombresCompletos { get; set; } // Nombres del empleados
        public string NumeroIdentidad { get; set; } // Número de identidad del empleado

        // datos de la inasistencia idLicencia, idEmpleado, FechaInasistencia

        public int IdLicencia { get; set; } // Identificador de la licencia
        public DateOnly FechaInasistencia { get; set; } // Fecha de la inasistenci
        //TotalInasistencias


    }
}
