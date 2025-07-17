using NominaPISIB.Infraestructura.AccesoDatos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 1er paso Leer la variable de conexión de la base de datos desde el archivo appsettings.json
var connectionString = builder.Configuration.GetConnectionString("ConeccionBaseNomina");
// 2do configurar el DbContext para usar la cadena de conexión
//builder.Services.AddDbContext< NominaPISIBContext >opcions=>     opcions.UseSqlServer(connectionString));


// configurar los servicios de la aplicacion
// 
//builder.Services.AddScoped<NominaPISIB.Aplicacion.Servicios.IEmpleadosServicio, NominaPISIB.Aplicacion.ServiciosImpl.EmpleadosServicioImpl>();
// configurar los servicios de la aplicacion

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
