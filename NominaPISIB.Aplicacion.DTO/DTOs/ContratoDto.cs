using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaPISIB.Aplicacion.DTO.DTOs
{

    //este dto se usa en HistorialContratoEmpleados
    public class ContratoDto
    {
        public int idContrato { get; set; }
        public decimal ContratoSalario { get; set; }

        public DateOnly FechaInicioContrato { get; set; }

        public DateOnly ContratoFechaFin { get; set; }
    }
}
