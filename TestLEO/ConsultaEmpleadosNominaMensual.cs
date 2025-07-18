﻿using Microsoft.EntityFrameworkCore;
using NominaPISIB.Aplicacion.Servicios;
using NominaPISIB.Aplicacion.ServiciosImpl;
using NominaPISIB.Infraestructura.AccesoDatos;


namespace TestLEO
{
    public class ConsultaEmpleadosNominaMensual // ESTA CONSULTA SE REALISA PARA OBTENER EL REPORTE DE NOMINA MENSUAL DE LOS EMPLEADOS EN DETERMINADA FECHA
    {
        private NominaPISIBContext _context;
        private IEmpleadosServicio _empleadoNomi;

        [SetUp]
        public void Setup()
        {

            var opcion = new DbContextOptionsBuilder<NominaPISIBContext>().UseSqlServer("Data Source=(localdb)\\leo;Initial Catalog=NominaPisip;Integrated Security=True")
                .Options;

            _context = new NominaPISIBContext(opcion);
            _empleadoNomi = new EmpleadosServicioImpl(_context);
        }

 
        [Test]
        public async Task TestReporteNominaEmpleado()
        {
            
           // var pruebaReporteNominaEmpleado = await _empleadoNomi.ObtenerReporteNominaMensual(1, 2025);
           // Console.WriteLine(pruebaReporteNominaEmpleado);
            Assert.Pass();
        }

        [TearDown]
        public void Terminar()
        {
            _context.Dispose();
        }
    }
}