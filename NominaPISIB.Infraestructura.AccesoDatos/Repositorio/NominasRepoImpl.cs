using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NominaPISIB.Aplicacion.DTO.DTOs;
using NominaPISIB.Dominio.Modelos.Abstracciones;
namespace NominaPISIB.Infraestructura.AccesoDatos.Repositorio
{
    public class NominasRepoImpl : RepositorioImpl<Nominas>, INominasRepo
    {
        private readonly NominaPISIBContext _context;
        public NominasRepoImpl(NominaPISIBContext context) : base(context)
        {
            this._context = context;
        }    //para el reporte de descuentos mensual
       
        
        

       
    }
    
}
