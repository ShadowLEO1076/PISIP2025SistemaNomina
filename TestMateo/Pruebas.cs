using Microsoft.EntityFrameworkCore;
using NominaPISIB.Aplicacion.Servicios;
using NominaPISIB.Aplicacion.ServiciosImpl;
using NominaPISIB.Infraestructura.AccesoDatos;

namespace TestMateo
{
    public class Tests
    {
        private NominaPISIBContext _context;
        private IPuestosServicio _puestosServ;
        private IEmpleadosServicio _empleServ;
        private IAsistenciasServicio _asisServ;

        [SetUp]
        public void Setup()
        {
            //esta config funciona solo en mi compu.
            var opcion = new DbContextOptionsBuilder<NominaPISIBContext>()
                .UseSqlServer("Data Source=DESKTOP-NCNTGBP\\MIPRIMERSQL2024;Initial Catalog=NominaPisip;Integrated Security=True;TrustServerCertificate=True;")
                .Options;
            _context = new NominaPISIBContext( opcion );
            _puestosServ = new PuestosServicioImpl( _context );
            _empleServ =new EmpleadosServicioImpl(_context );
            _asisServ = new AsistenciasServicioImpl(_context);
        }

        [Test]
         public async Task Test1()
        {
            //var puestoPrueba = new Puestos { PuestoNombre = "INGENIERO EN TELECOMUNICACIONES", PuestoSalario = (decimal)570.56, PuestoVacacionesCantidad = 40};

            //await _puestosServ.UpdateAsync( puestoPrueba );

            //var prueba = await _empleServ.ObtenerContratoActivoEmpleados();
            //var prueba2 = await _empleServ.ObtenerHistorialPorEmpleado("Mateo", "Vasquez");

            //Console.WriteLine( prueba2 );

            //var prueba3 = await _empleServ.ObtenerBonificacionesDeEmpleadoPorAnio("Mateo", "Vasquez", 2025);
            //Console.WriteLine( prueba3 );

            //var pruebaMas = await _empleServ.ObtenerEmpleadosActivos();
            //Console.WriteLine(pruebaMas);

            /* var pruebaEmpleado = await _empleServ.ObtenerEmpleadoPorNombre("Mateo", "Vasquez");
             string cambio = "0987232123";
             pruebaEmpleado.EmpleadoTelfPersonal = cambio;
             await _empleServ.UpdateAsync( pruebaEmpleado );*/

            /*
            var pruebaSuma = await _empleServ.ObtenerBonificacionesDeEmpleadoPorAnioYMes("Mateo", "Vasquez", 2025, 7);

            var pruebaSum2 = _empleServ.CalcularBonificacionesDeEmpleadoPorAnioYMesAsync(pruebaSuma);
            */

            var pruebaAsis = await _asisServ.ObtenerAsistenciasEmpleadoPorAnioYMes("Mateo", "Vasquez", 2025, 07);
            Console.WriteLine( pruebaAsis );

           Assert.Pass();
        }

        [TearDown]
        public void Terminar()
        {
            _context.Dispose();
        }
    }
}