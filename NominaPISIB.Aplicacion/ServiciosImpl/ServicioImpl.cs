using NominaPISIB.Aplicacion.Servicios;
using NominaPISIB.Dominio.Modelos.Abstracciones;
using NominaPISIB.Infraestructura.AccesoDatos;
using NominaPISIB.Infraestructura.AccesoDatos.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaPISIB.Aplicacion.ServiciosImpl
{
    public class ServicioImpl<T> : IService<T> where T : class
    {
        IRepository<T> _repository;

        public ServicioImpl(NominaPISIBContext context)
        {
            _repository = new RepositorioImpl<T>(context);
        }
        public async Task AddAsync(T entity)
        {
            try 
            {
                await _repository.AddAsync(entity);
            }
            catch(Exception ex) { throw new Exception("Error - Service: el dato no se pudo añadir: " + ex.Message); }
        }

        public async Task DeleteAsync(T entity)
        {
            try
            {
                await _repository.DeleteAsync(entity);
            }
            catch (Exception ex) { throw new Exception("Error - Service: el dato no se pudo eliminar: " + ex.Message); }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
               return await _repository.GetAllAsync();
            }
            catch (Exception ex) { throw new Exception("Error - Service: los datos no se pudieron obtener: " + ex.Message); }
        }

        public async Task<T> GetByIdAsync(int id)
        {
            try
            {
                return await _repository.GetByIdAsync(id);
            }
            catch (Exception ex) { throw new Exception("Error - Service: el dato no se pudo recuperar: " + ex.Message); }
        }

        public async Task UpdateAsync(T entity)
        {
            try
            {
                await _repository.UpdateAsync(entity);
            }
            catch (Exception ex) { throw new Exception("Error - Service: el dato no se pudo actualizar: " + ex.Message); }
        }
    }
}
