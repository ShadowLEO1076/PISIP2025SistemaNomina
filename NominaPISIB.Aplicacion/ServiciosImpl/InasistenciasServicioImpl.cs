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
    public class InasistenciasServicioImpl : ServicioImpl<Inasistencias>, IInasistenciasServicio
    {
        private IInasistenciasRepo _repo;
        private readonly NominaPISIBContext _context;
        public InasistenciasServicioImpl(NominaPISIBContext context) : base(context)
        {
            _context = context;
            _repo = new InasistenciasRepoImpl(context);

        }
    }
}
