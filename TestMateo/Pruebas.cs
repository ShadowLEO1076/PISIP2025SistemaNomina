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

        [SetUp]
        public void Setup()
        {
            //esta config funciona solo en mi compu.
            var opcion = new DbContextOptionsBuilder<NominaPISIBContext>().UseSqlServer("Data Source=DESKTOP-NCNTGBP\\MIPRIMERSQL2024;Initial Catalog=NominaPisip;Integrated Security=True;TrustServerCertificate=True;")
                .Options;
            _context = new NominaPISIBContext( opcion );
            _puestosServ = new PuestosServicioImpl( _context );
            _empleServ =new EmpleadosServicioImpl(_context );
        }

        [Test]
         public async Task Test1()
        {
            /*var puestoPrueba = new Puestos { idPuesto = 2 , PuestoNombre = "INGENIERO EN TELECOMUNICACIONES", PuestoSalario = (decimal)560.56, PuestoVacacionesCantidad = 40};

            await _puestosServ.AddAsync( puestoPrueba );*/

            var prueba = await _empleServ.ObtenerContratoActivoEmpleados();
            Console.WriteLine( prueba );
            Assert.Pass();
        }

        [TearDown]
        public void Terminar()
        {
            _context.Dispose();
        }
    }
}