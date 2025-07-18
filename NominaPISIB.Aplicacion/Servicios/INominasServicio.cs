﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using NominaPISIB.Infraestructura.AccesoDatos;

namespace NominaPISIB.Aplicacion.Servicios
{
    [ServiceContract]
    public interface INominasServicio : IService<Nominas>

    // : IService<Nominas> METODOS PARA CRUD DE NOMINAS -> esto ya lo tenemos gracias al genérico
    {
        [OperationContract]
        // usará muchos métodos para al final usar el AddAsync
        public Task InsertarNominaAutomatizado(string name, string lastname, int year, int month);

        [OperationContract]
        public decimal CalcularSalarioNeto(decimal salaritoBruto, int diasTrabajados);
        /*
        [OperationContract]
        Task<bool> RegistrarNominaAsync(int empleadoId, DateTime fechaPago, decimal monto);
        [OperationContract]
        Task<bool> ActualizarNominaAsync(int nominaId, DateTime nuevaFechaPago, decimal nuevoMonto);
        [OperationContract]
        Task<bool> EliminarNominaAsync(int nominaId);
        [OperationContract]
        Task<IEnumerable<string>> ObtenerNominasPorEmpleadoAsync(int empleadoId);
        [OperationContract]
        Task<IEnumerable<string>> ObtenerNominasPorFechaAsync(DateTime fecha);
        [OperationContract]
        Task<string> ObtenerDetallesNominaAsync(int nominaId);
        [OperationContract]
        Task<bool> NotificarNominaRegistradaAsync(int empleadoId, string mensajeNotificacion);
        [OperationContract]
        Task<bool> NotificarNominaActualizadaAsync(int nominaId, string mensajeNotificacion);
        [OperationContract]
        Task<bool> NotificarNominaEliminadaAsync(int nominaId, string mensajeNotificacion);
        */





    }
}
