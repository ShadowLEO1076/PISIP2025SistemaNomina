using Microsoft.EntityFrameworkCore;
using NominaPISIB.Aplicacion.Servicios;
using NominaPISIB.Aplicacion.ServiciosImpl;
using NominaPISIB.Infraestructura.AccesoDatos;


namespace TestLEO
{
    public class TestNominaDTO
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
            // var puestoPrueba = new Puestos { PuestoNombre = "INGENIERO EN TELECOMUNICACIONES", PuestoSalario = (decimal)560.56, PuestoVacacionesCantidad = 40};

            // await _puestosServ.AddAsync( puestoPrueba );

            // var prueba = await _empleServ.ObtenerContratoActivoEmpleados();
            var pruebaReporteNominaEmpleado = await _empleadoNomi.ObtenerReporteNominaMensual(5, 2024);
            Console.WriteLine(pruebaReporteNominaEmpleado);
            Assert.Pass();
        }

        [TearDown]
        public void Terminar()
        {
            _context.Dispose();
        }
    }
}