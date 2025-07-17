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
    public class ContratosTipoServicioImpl : ServicioImpl<ContratosTipo>, IContratosTipoServicio
    {
        IContratosTipoRepo _repo;
        private readonly NominaPISIBContext _context;
        public ContratosTipoServicioImpl(NominaPISIBContext context) : base(context)
        {
            _context = context;
            _repo = new ContratosTipoRepoImpl(context);
        }
        public async Task<List<ContratosTipo>> GetAll()
        {
            try
            {
                return await _repo.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Error - ContatoServicioImpl : error al hallar los datos. " + ex.Message);

            }

        }
        Task<List<Contratos>> IContratosTipoServicio.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}

     

