using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NominaPISIB.Aplicacion.DTO.DTOs;
using NominaPISIB.Aplicacion.Servicios;
using NominaPISIB.Dominio.Modelos.Abstracciones;
using NominaPISIB.Infraestructura.AccesoDatos;
using NominaPISIB.Infraestructura.AccesoDatos.Repositorio;

namespace NominaPISIB.Aplicacion.ServiciosImpl
{
    public class ContratosServicioImpl : ServicioImpl<Contratos>, IContratosServicio
    {
        IContratosRepo _repo;
        private readonly NominaPISIBContext _context;
        public ContratosServicioImpl(NominaPISIBContext context) : base(context)
        {
            _context = context;
            _repo = new ContratosRepoImpl(context);
        }
        public async Task<List<Contratos>> GetAll()
        {
            try
            {
                return await _repo.GetAll();
            }
            catch(Exception ex)
            {
                throw new Exception("Error - ContatoServicioImpl : error al hallar los datos. " + ex.Message);

            }
            
        }
    }
}
