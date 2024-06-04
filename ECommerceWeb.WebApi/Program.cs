using ECommerceWeb.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Sesion04.ECommerceWeb.Repositorios.Implementaciones;
using Sesion04.ECommerceWeb.Repositorios.Interfaces;

var builder = WebApplication.CreateBuilder(args);

var cors = "Blazor";
// Habilitamos el CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy(cors, builder =>
    {
        builder.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddDbContext<ECommerceDbContext>(options =>
{
    // Estamos configurando la conexion al EF Core a traves del archivo de configuracion
    options.UseSqlServer(builder.Configuration.GetConnectionString("Conexion"));
});

// Agregamos los repositorios
builder.Services.AddTransient<ICategoriaRepositorio, CategoriaRepositorio>();
builder.Services.AddTransient<IProductoRepositorio, ProductoRepositorio>();
builder.Services.AddTransient<IVentaRepositorio, VentaRepositorio>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("api/categorias", (ICategoriaRepositorio repositorio) =>
{
    var categorias = repositorio.Listar();

    return Results.Ok(categorias);
});

app.MapControllers();
app.UseCors(cors);

app.Run();
