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
        private IBonificacionesServicio _boniServ;
        private IDescuentosServicio _descServ;
        private IInasistenciasServicio _inasServ;
        private INominasServicio _nomiServ;

        [SetUp]
        public void Setup()
        {
            //esta config funciona solo en mi compu.
            var opcion = new DbContextOptionsBuilder<NominaPISIBContext>()
                .UseSqlServer("Data Source=DESKTOP-NCNTGBP\\MIPRIMERSQL2024;Initial Catalog=NominaPisip;Integrated Security=True;TrustServerCertificate=True; Encrypt=True")
                .Options;
            _context = new NominaPISIBContext( opcion );
            _puestosServ = new PuestosServicioImpl( _context );
            _empleServ =new EmpleadosServicioImpl(_context );
            _asisServ = new AsistenciasServicioImpl(_context);
            _boniServ = new BonificacionesServicioImpl(_context);
            _descServ = new DescuentosServicioImpl(_context) ;
            _inasServ = new InasistenciasServicioImpl(_context ) ;
            //_nomiServ = new NominasServicioImpl(_context);
        }

        [Test]
         public async Task Test1()
        {
            //var puestoPrueba = new Puestos { PuestoNombre = "INGENIERO EN TELECOMUNICACIONES", PuestoSalario = (decimal)570.56, PuestoVacacionesCantidad = 40};

            //await _puestosServ.UpdateAsync( puestoPrueba );

            //var prueba = await _empleServ.ObtenerContratoActivoEmpleados();
            //var prueba2 = await _empleServ.ObtenerHistorialPorEmpleado("Juan", "Pérez");

            //Console.WriteLine( prueba2 );

            //var prueba3 = await _empleServ.ObtenerBonificacionesDeEmpleadoPorAnio("Mateo", "Vasquez", 2025);
            //Console.WriteLine( prueba3 );

            //var pruebaMas = await _empleServ.ObtenerEmpleadosActivos();
            //Console.WriteLine(pruebaMas);

            /* var pruebaEmpleado = await _empleServ.ObtenerEmpleadoPorNombre("Mateo", "Vasquez");
             string cambio = "0987232123";
             pruebaEmpleado.EmpleadoTelfPersonal = cambio;
             await _empleServ.UpdateAsync( pruebaEmpleado );*/

            /*var pruebaBoni = await _boniServ.ObtenerBonificacionesDeEmpleadoPorAnioYMes("Mateo", "Vasquez", 2025, 7);
            Console.WriteLine( pruebaBoni );^*/

            //var pruebaDesc = await _descServ.ObtenerDescuentosDeEmpleadoPorAnioYMes("Mateo", "Vasquez", 2025, 7);
            //Console.WriteLine(pruebaDesc);

            /*
            var pruebaAsis = await _asisServ.ObtenerAsistenciasEmpleadoPorAnioYMes("Mateo", "Vasquez", 2025, 7)
                ;
             var asisTotal = _asisServ.ContabilizarAsistencias(pruebaAsis);
            Console.WriteLine(asisTotal);
            */

            /*
            var pruebaInas = await _inasServ.ObtenerInasistenciasEmpleadoPorAnioYMes("Mateo", "Vasquez", 2025, 5);
            var inasisTotal = _inasServ.ContabilizarInasistencias(pruebaInas);
            Console.WriteLine(inasisTotal);
            */
            
            //r pruebaContrato = await _empleServ.ObtenerContratoActivoPorEmpleado("Juan", "Pérez");
           await  _nomiServ.InsertarNominaAutomatizado("Juan", "Pérez", 2025, 7);

            //Console.WriteLine( prueba3);

            Assert.Pass();
        }

        [TearDown]
        public void Terminar()
        {
            _context.Dispose();
        }
    }
}