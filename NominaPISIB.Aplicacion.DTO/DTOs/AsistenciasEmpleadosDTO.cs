using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaPISIB.Aplicacion.DTO.DTOs
{
    public class AsistenciasEmpleadosDTO
    {
        public string NombresCompletos { get; set; }

        public List<AsistenciaDTO> Asistencias { get; set; }
    }
}
