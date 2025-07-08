using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaPISIB.Aplicacion.DTO.DTOs
{
    public class ReporteDescuentosNominaDTO
    {
        // Datos del empleado
        public int IdEmpleado { get; set; }  //ok
        public string NombresCompletos { get; set; } // ok
        


        // Datos de la nómina
        public int Anio { get; set; } // ok
        public int Mes { get; set; } // ok
        public decimal SalarioBase { get; set; }
        public decimal SueldoNeto { get; set; } // ok
        // descuentos empleado nomina
        public decimal TotalDescuentosEmpleado { get; set; } // Total de descuentos aplicados al empleado en el mes.  // ok
        public DateOnly FechaEmision { get; set; } // Fecha de emisión de la nómina mensual, se puede usar para filtrar por mes y año. // ok

        // Datos de los descuentos
        public decimal TotalDescuentos { get; set; }
        public List<string> DescripcionDescuentos { get; set; } = new();
        public List<decimal> MontoDescuentos { get; set; } = new();

        // contrato estado contrato
        public bool? EstadoContrato { get; set; } // Activo, Finalizado, etc. // ok

    }
}

