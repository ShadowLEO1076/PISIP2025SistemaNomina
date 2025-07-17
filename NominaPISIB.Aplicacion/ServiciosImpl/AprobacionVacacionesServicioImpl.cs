using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NominaPISIB.Aplicacion.Servicios;
using NominaPISIB.Dominio.Modelos.Abstracciones;
using NominaPISIB.Infraestructura.AccesoDatos;
using NominaPISIB.Infraestructura.AccesoDatos.Repositorio;

namespace NominaPISIB.Aplicacion.ServiciosImpl
{
    public class AprobacionVacacionesServicioImpl : ServicioImpl<AprobacionVacaciones>, IAprobacionVacacionesServicio
    {
        private readonly IAprobacionVacacionesRepo repo;
        public AprobacionVacacionesServicioImpl(NominaPISIBContext context) : base(context)
        {
            repo = new AprobacionVacacionesRepoImpl(context);
        }

    }
}
