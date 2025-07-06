using Microsoft.EntityFrameworkCore;
using NominaPISIB.Aplicacion.Servicios;
using NominaPISIB.Aplicacion.ServiciosImpl;
using NominaPISIB.Infraestructura.AccesoDatos;


namespace TestLEO  // no funccionsionó este test esta por revisar es interesante porque depende del test luego toca añadir nuevas implementaciones
{
    public class Tests
    {
        private NominaPISIBContext _context;
        private IAprobacionVacacionesServicio _aprovacionvServ;
        //private IPuestosServicio _puestosServ;

        [SetUp]
        public void Setup()
        {
            //esta config funciona solo en mi compu.
            var opcion = new DbContextOptionsBuilder<NominaPISIBContext>().UseSqlServer("Data Source=(localdb)\\leo;Initial Catalog=NominaPisip;Integrated Security=True")
                .Options;

            _context = new NominaPISIBContext(opcion);
            _aprovacionvServ = new AprobacionVacacionesServicioImpl(_context);
            //_puestosServ = new PuestosServicioImpl(_context);
        }

        [Test]
        
       public async Task TestAprobacionVacaciones()
        {
            var AprobacionVacacionesPrueva = new AprobacionVacaciones
            {
                idAprobacionVacacion = 1,
                idSolicitudVacacion = 1,
                AprobacionVacacionFecha = new DateOnly(2025, 7, 5) // Correctly initializing DateOnly
            };

            await _aprovacionvServ.AddAsync(AprobacionVacacionesPrueva); // Corrected variable name
            // Assert.Pass();
        }
        // test que me copie de mateo para provar conección a la base de datos y el servicio de puestos
        /*public async Task Test1()
        {
            var puestoPrueba = new Puestos { idPuesto = 1, PuestoNombre = "INGENIERO EN SISTEMAS", PuestoSalario = (decimal)560.56, PuestoVacacionesCantidad = 40 };

            await _puestosServ.AddAsync(puestoPrueba);
            //Assert.Pass();
        }*/

        [TearDown]
        public void Terminar()
        {
            _context.Dispose();
        }
    }
}