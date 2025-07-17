using Microsoft.EntityFrameworkCore;
using NominaPISIB.Aplicacion.Servicios;
using NominaPISIB.Aplicacion.ServiciosImpl;
using NominaPISIB.Infraestructura.AccesoDatos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// voy hacer tres cosas

// 1. hacer que cuando se levante la aplicacion automaticamente se vaya al appsettings.json y lea la cadena de conexion y la guarde en una variable de entorno llamada "DefaultConnection" para que luego pueda ser usada por el DbContext NominaPISIBContext
// 2 Crear mi dbcontext general o global con la conection string que esta en el archivo de configuraciones
// 3. configurar mis servicios mis service para que automaticamente esten disponibles cuando arranque mi API



// 1. leer la cadena de conexion del appsettings.json y guardarla en una variable de entorno
var connectionDB = builder.Configuration.GetConnectionString("DefaultConnection");
//var connectionDB = builder.Configuration.GetConnectionString("ConnectionMateo");
// 2. crear el DbContext global con la cadena de conexion
builder.Services.AddDbContext<NominaPISIBContext>(options =>
    options.UseSqlServer(connectionDB),ServiceLifetime.Scoped);
// 3. configurar los servicios para que esten disponibles

builder.Services.AddScoped<IEmpleadosVacacionesTotalesServicio, EmpleadosVacacionesTotalesServicioImpl>();
// ahora para inasistencias
builder.Services.AddScoped<IInasistenciasServicio, InasistenciasServicioImpl>();

// ahora para licencias

builder.Services.AddScoped<ILicenciasServicio, LicenciasServicioImpl>();

// ahora para Nominas
builder.Services.AddScoped<INominasServicio, NominasServicioImpl>();
// ahora para puestos
builder.Services.AddScoped<IPuestosServicio, PuestosServicioImpl>();
// ahora para la interfas Iservicio genericay su impl generica ServicioImpl
builder.Services.AddScoped(typeof(IService<>), typeof(ServicioImpl<>));
// ahora para solicitud vacaciones
builder.Services.AddScoped<ISolicitudVacacionesServicio, SolicitudVacacionesServicioImpl>();
// de Mateo
builder.Services.AddScoped<IAprobacionVacacionesServicio, AprobacionVacacionesServicioImpl>();

builder.Services.AddScoped<IAsistenciasServicio,AsistenciasServicioImpl>();
// de bonificaciones 
builder.Services.AddScoped<IBonificacionesServicio, BonificacionesServicioImpl>();


var app = builder.Build();

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
