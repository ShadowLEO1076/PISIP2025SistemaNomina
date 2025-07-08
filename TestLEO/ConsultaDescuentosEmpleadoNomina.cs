using Microsoft.EntityFrameworkCore;
using NominaPISIB.Aplicacion.Servicios;
using NominaPISIB.Aplicacion.ServiciosImpl;
using NominaPISIB.Infraestructura.AccesoDatos;


namespace TestLEO
{
    public class ConsultaDescuentosEmpleadoNomina
    {
        private NominaPISIBContext _context;
        private INominasServicio _nominaP;
        private IEmpleadosServicio _empleadosServicio;

        [SetUp]
        public void Setup()
        {

            var opcion = new DbContextOptionsBuilder<NominaPISIBContext>().UseSqlServer("Data Source=(localdb)\\leo;Initial Catalog=NominaPisip;Integrated Security=True")
                .Options;

            _context = new NominaPISIBContext(opcion);
            _nominaP = new NominasServicioImpl(_context);
            _empleadosServicio = new EmpleadosServicioImpl(_context);
        }


        [Test]
        public async Task TestReporteNominaEmpleado()
        {

            var pruebaReporteNominaDescuento = await _empleadosServicio.ObtenerReporteDescuentosMensual(1, 2025);
            Console.WriteLine(pruebaReporteNominaDescuento);
            Assert.Pass();
        }

        [TearDown]
        public void Terminar()
        {
            _context.Dispose();
        }
    }
}