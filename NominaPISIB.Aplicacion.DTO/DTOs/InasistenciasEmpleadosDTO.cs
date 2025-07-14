using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaPISIB.Aplicacion.DTO.DTOs
{
    public class InasistenciasEmpleadosDTO
    {
        public string NombresCompletos { get; set; }

        public List<InasistenciaDTO> Inasistencias { get; set; }
    }
}
