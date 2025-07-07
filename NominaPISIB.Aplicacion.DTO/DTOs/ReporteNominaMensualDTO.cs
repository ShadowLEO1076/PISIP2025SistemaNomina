using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaPISIB.Aplicacion.DTO.DTOs
{
    // este dto no es para los reportes finales por empleado, es para el reporte de nómina mensual mensual para gestion se genera por empleado.
    public class ReporteNominaMensualDTO
    {
        //Datos del período viene de la tabla de nómina
        public int Anio { get; set; } // LISTO
        public int Mes { get; set; } // LISTO
        public decimal TotalHorasExtras { get; set; }  // LISTO
        public decimal TotalBonificaciones { get; set; } // LISTO
        public decimal TotalDescuentos { get; set; } // LISTO
        public DateOnly FechaEmision { get; set; } // Fecha de emisión de la nómina mensual, se puede usar para filtrar por mes y año.
        public decimal SalarioNeto { get; set; }  // El total a pagar se calcula como: Salario Base + Total Horas Extras + Total Bonificaciones - Total Descuentos


        //Datos del empleado viene de la tabla de empleados

        public int IdEmpleado { get; set; } // LISTO
        public string NombresEmpleados { get; set; } // LISTO
        //public string NumeroIdentidad { get; set; }

        // tabla bonificaciones

        public decimal TotalBonificacionesEmpleado { get; set; } // Total de bonificaciones del empleado en el mes.

        // tabla descuentos
        public decimal TotalDescuentosEmpleado { get; set; } // Total de descuentos del empleado en el mes.



        //Datos financieros viene en la tabla de contratos
        public decimal SalarioBase { get; set; } // El salario base se define en el contrato del empleado.
        //Datos administrativos
        public bool? EstadoContrato { get; set; } // Activo, Finalizado, etc. 
    }
}
