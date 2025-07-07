using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NominaPISIB.Aplicacion.DTO.DTOs;
using NominaPISIB.Dominio.Modelos.Abstracciones;
namespace NominaPISIB.Infraestructura.AccesoDatos.Repositorio
{
    public class BonificacionesRepoImpl : RepositorioImpl<Bonificaciones>, IBonificacionesRepo
    {
   
        public BonificacionesRepoImpl(NominaPISIBContext context) : base(context)
        {
        }
    }
}
