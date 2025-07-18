﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NominaPISIB.Dominio.Modelos.Abstracciones;
namespace NominaPISIB.Infraestructura.AccesoDatos.Repositorio
{
    public class PuestosRepoImpl : RepositorioImpl<Puestos>, IPuestosRepo
    {
        NominaPISIBContext _context;
        public PuestosRepoImpl(NominaPISIBContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<List<Puestos>> GetAll()
        { 
            try
            {

                var puestos =
                    _context.Puestos.ToListAsync();

                return await puestos;
            }
            catch (Exception ex) { throw new Exception("Error -  PuestosRepoImpl : No se pudo traer los datos. " + ex.Message); }
        }

        public Task<Puestos> ObtenerPuestoPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }
    } 
}
