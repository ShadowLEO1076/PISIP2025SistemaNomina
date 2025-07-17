using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaPISIB.Aplicacion.DTO.DTOs
{
    public class InasistenciaDTO
    {
        public string LicenciaNombre { get; set; }
        public int LicenciaRemunerable { get; set; }
        public DateOnly InasistenciaFecha { get; set; }
    }
}
