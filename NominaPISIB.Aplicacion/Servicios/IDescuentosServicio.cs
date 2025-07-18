﻿using NominaPISIB.Aplicacion.DTO.DTOs;
using NominaPISIB.Infraestructura.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace NominaPISIB.Aplicacion.Servicios
{
    [ServiceContract]
    public interface IDescuentosServicio : IService<Descuentos>
    {
        [OperationContract]
        public Task<List<DescuentosEmpleadosDTO>> ObtenerDescuentosDeEmpleadoPorAnioYMes(string name, string lastname, int year, int month);

        [OperationContract]
        decimal CalcularDescuentosDeEmpleadoPorAnioYMes(List<DescuentosEmpleadosDTO> lista);
    }
}
