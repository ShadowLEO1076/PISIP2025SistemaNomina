using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using NominaPISIB.Aplicacion.Servicios;
using NominaPISIB.Dominio.Modelos.Abstracciones;
using NominaPISIB.Infraestructura.AccesoDatos;
using NominaPISIB.Infraestructura.AccesoDatos.Repositorio;

namespace NominaPISIB.Aplicacion.ServiciosImpl
{
    public class EmpleadosVacacionesTotalesServicioImpl : ServicioImpl<EmpleadosVacacionesTotales>, IEmpleadosVacacionesTotalesServicio
    {
        private IEmpleadosVacacionesTotalesRepo _repo;
        private readonly NominaPISIBContext _context;
        public EmpleadosVacacionesTotalesServicioImpl(NominaPISIBContext context) : base(context)
        {
            _context = context;
            _repo = new EmpleadosVacacionesTotalesRepoImpl(context);

        
        }
    }
}
