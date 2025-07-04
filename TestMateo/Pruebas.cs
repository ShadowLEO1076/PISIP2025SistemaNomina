using Microsoft.EntityFrameworkCore;
using NominaPISIB.Infraestructura.AccesoDatos;

namespace TestMateo
{
    public class Tests
    {
        private NominaPISIBContext _context;

        [SetUp]
        public void Setup()
        {
            //esta config funciona solo en mi compu.
            var opcion = new DbContextOptionsBuilder<NominaPISIBContext>().UseSqlServer("Data Source=DESKTOP-NCNTGBP\\MIPRIMERSQL2024;Initial Catalog=NominaPisip;Integrated Security=True;TrustServerCertificate=True;")
                .Options;
            _context = new NominaPISIBContext( opcion );
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [TearDown]
        public void Terminar()
        {
            _context.Dispose();
        }
    }
}