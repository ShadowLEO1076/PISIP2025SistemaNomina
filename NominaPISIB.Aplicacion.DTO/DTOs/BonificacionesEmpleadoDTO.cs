using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaPISIB.Aplicacion.DTO.DTOs
{
    public class BonificacionesEmpleadoDTO
    {
        public string NombresCompletos { get; set; }
        public int boniYear { get; set; }
        public List<BonificacionesDTO> bonificaciones { get; set; }
    }
}
