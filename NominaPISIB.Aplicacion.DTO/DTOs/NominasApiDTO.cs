using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaPISIB.Aplicacion.DTO.DTOs
{
    /// <summary>
    ///Usar esta entidad par el el método public async Task InsertarNominaAutomatizado(string name, string lastname, int year, int month)
    /// </summary>
    public class NominasApiDTO
    {
            public string name {  get; set; }
            public string lastname {  get; set; }
            public int year { get; set; }
            public int month {  get; set; }
    }
}
