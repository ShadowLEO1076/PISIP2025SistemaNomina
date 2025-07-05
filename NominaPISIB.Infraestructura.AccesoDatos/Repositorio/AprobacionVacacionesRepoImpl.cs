using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NominaPISIB.Dominio.Modelos.Abstracciones;

namespace NominaPISIB.Infraestructura.AccesoDatos.Repositorio
{
    public class AprobacionVacacionesRepoImpl : RepositorioImpl<AprobacionVacaciones>, IAprobacionVacacionesRepo
    {
        public AprobacionVacacionesRepoImpl(NominaPISIBContext context) : base(context)
        {
        }
    }
}

