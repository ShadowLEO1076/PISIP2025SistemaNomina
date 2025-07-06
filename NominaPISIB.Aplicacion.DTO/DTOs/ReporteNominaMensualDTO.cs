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
        public int Anio { get; set; } 
        public int Mes { get; set; } 
        public decimal TotalHorasExtras { get; set; } 
        public decimal TotalBonificaciones { get; set; }
        public decimal TotalDescuentos { get; set; }
        public decimal TotalAPagar { get; set; }  // El total a pagar se calcula como: Salario Base + Total Horas Extras + Total Bonificaciones - Total Descuentos


        //Datos del empleado viene de la tabla de empleados
        public int IdEmpleado { get; set; } 
        public string NombresCompletos { get; set; } 
        public string NumeroIdentidad { get; set; } 
        public string Genero { get; set; } 
        public DateTime FechaIngreso { get; set; } // Fecha de ingreso del empleado a la empresa.



        // viene de la tabla de puestos
        public string Puesto { get; set; }

        //Datos financieros viene en la tabla de contratos
        public decimal SalarioBase { get; set; } // El salario base se define en el contrato del empleado.
        //Datos administrativos
        public string EstadoContrato { get; set; } // Activo, Finalizado, etc. 
    }
}
