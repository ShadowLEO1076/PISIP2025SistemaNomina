using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaPISIB.Aplicacion.DTO.DTOs
{
    public class HistorialContratoEmpleados
    {
        public string NombresCompletos { get; set; }

        public DateOnly FechaIngreso { get; set; }

        //usamos el dto pues no debemos entrar a Modelos
        public List<ContratoDto> ContratosEmpleado { get; set; }
    }
}
