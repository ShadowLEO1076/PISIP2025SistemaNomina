using Microsoft.EntityFrameworkCore;
using NominaPISIB.Aplicacion.Servicios;
using NominaPISIB.Aplicacion.ServiciosImpl;
using NominaPISIB.Infraestructura.AccesoDatos;


namespace TestLEO
{
    public class ConsultaEmpleadoInacistenciaLicencia 
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
        // Esta consulta se realiza para obtener el reporte de inasistencias y licencias de los empleados en determinada fecha

        public async Task ConsultaEmpleadosInasistenciasLicencia()
        {
            var pruebaReporteInacistencia = await _empleadoNomi.ObtenerReporteEmpleadosInasistenciasLicencia(1, 2025);
            Console.WriteLine(pruebaReporteInacistencia);
            Assert.Pass();

        }



        [TearDown]
        public void Terminar()
        {
            _context.Dispose();
        }
    }
}