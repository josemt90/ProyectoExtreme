using Microsoft.EntityFrameworkCore;
using ProyectoExtreme_Datos;
using ProyectoExtreme_Negocio.Clases;
using ProyectoExtreme_Negocio.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// CONFIGURAR EL ACCESO A DATOS
var conn = builder.Configuration.GetConnectionString("AppConnection"); // crea una variable con la cadena de conexion
builder.Services.AddDbContext<ProyectoExtremeContext>(x=>x.UseSqlServer(conn)); // construye el contexto


//CONFIGURAR LAS INTERFACES PARA QUE EL CONTROLADOR LAS PUEDA USAR
builder.Services.AddScoped<IVehiculo,LogicaVehiculo>();
builder.Services.AddScoped<IUsuario,LogicaUsuario>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
