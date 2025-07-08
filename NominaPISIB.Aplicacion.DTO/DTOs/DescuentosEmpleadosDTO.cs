using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaPISIB.Aplicacion.DTO.DTOs
{
    public class DescuentosEmpleadosDTO
    {
        public string NombresCompletos { get; set; }
        public int boniYear { get; set; }
        public List<DescuentoDTO> Descuentos{ get; set; }
    }
}
