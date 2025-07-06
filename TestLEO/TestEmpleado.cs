using Microsoft.EntityFrameworkCore;
using NominaPISIB.Aplicacion.Servicios;
using NominaPISIB.Aplicacion.ServiciosImpl;
using NominaPISIB.Infraestructura.AccesoDatos;


namespace TestLEO
{
    public class Test
    {
        private NominaPISIBContext _context;
        private IEmpleadosServicio _empleadoServ;

        [SetUp]
        public void Setup()
        {
           
            var opcion = new DbContextOptionsBuilder<NominaPISIBContext>().UseSqlServer("Data Source=(localdb)\\leo;Initial Catalog=NominaPisip;Integrated Security=True")
                .Options;

            _context = new NominaPISIBContext(opcion);
            _empleadoServ = new EmpleadosServicioImpl(_context);
        }

        [Test]       
        public async Task Test1()
        {
            var EmpleadoPrueba = new Empleados 
            {
                // AQUI VOY AGREGAR TODOS LOS DATOS DEL CAMPO QUE PERTENESCAN A LA TABLA DE EMPLEADOS, PARA QUE SE PUEDA AÑADIR UN NUEVO EMPLEADO
                idEmpleado = 1,
                FKidPuesto = 1, // Asegúrate de que este ID exista en la tabla de Puestos
                EmpleadoNombres = "Juanito",
                EmpleadoApellidos = "Perez",
                EmpleadoCorreo = "ejemplo@gmail.com",
                EmpleadoFechaNacimiento = new DateOnly(1990, 1, 1),
                EmpleadoEstado = "Activo",
                EmpleadoGenero = "Masculino",
                EmpleadoTelfPersonal = "1234567890",
                EmpleadoFechaIngreso = new DateOnly(2025, 5, 1),
               
            };
            await _empleadoServ.AddAsync(EmpleadoPrueba);
            
        }

        [TearDown]
        public void Terminar()
        {
            _context.Dispose();
        }
    }
}