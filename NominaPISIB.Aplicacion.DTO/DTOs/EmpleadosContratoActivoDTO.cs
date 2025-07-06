using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaPISIB.Aplicacion.DTO.DTOs
{
    public class EmpleadosContratoActivoDTO
    {
        //datos del empleado
        public string NombresCompletos { get; set; }
        public string Correo { get; set; }
        public DateOnly FechaIngreso { get; set; }
        public string Genero { get; set; }
        public string Telefono { get; set; }


        // datos del contrato
        public DateOnly FechaInicioContrato { get; set; }
        public DateOnly FechaFinContrato { get; set; }
        public decimal Salario { get; set; }
    }
}
