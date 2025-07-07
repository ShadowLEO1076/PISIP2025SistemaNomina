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
        public int IdEmpleado { get; set; }
        public string NombresCompletos { get; set; }
        public string NumeroIdentidad { get; set; }
        public string EmpleadoCorreo { get; set; }
        public string Genero { get; set; }
        public DateTime FechaIngreso { get; set; } // Fecha de ingreso del empleado a la empresa.
        


        // Datos de la nómina
        public int Anio { get; set; }
        public int Mes { get; set; }
        public decimal SalarioBase { get; set; }
        public decimal SueldoNeto { get; set; }

        // Datos de los descuentos
        public decimal TotalDescuentos { get; set; }
        public List<string> DescripcionDescuentos { get; set; } = new();
        public List<decimal> MontoDescuentos { get; set; } = new();
    }
}

