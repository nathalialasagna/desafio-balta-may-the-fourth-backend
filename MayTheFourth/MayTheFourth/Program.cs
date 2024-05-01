using Carter;
using MayTheFourth.Domain.Interfaces.Repositories;
using MayTheFourth.Infra.Context;
using MayTheFourth.Infra.Repositories;
using MayTheFourth.Interfaces.Services;
using MayTheFourth.Mappings.Filme;
using MayTheFourth.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("RebelTech", builder =>
    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "MayTheFourth API - RebelTech",
        Version = "v1",
        Description = "API para consulta de dados do universo de Star Wars",
        Contact = new OpenApiContact
        {
            Url = new Uri("https://github.com/nathalialasagna/desafio-balta-may-the-fourth-backend")
        },
        License = new OpenApiLicense
        {
            Name = "MIT License"
        }
    });
});

builder.Services.ConfigureSwaggerGen(options => options.CustomSchemaIds(x => x.FullName));
builder.Services.AddCarter();

ConfigureServices(builder);

var app = builder.Build();
ConfigureApiServices(app);

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.MapCarter();

app.Run();

void ConfigureServices(WebApplicationBuilder builder)
{
    builder.Services.AddDbContext<MayTheFourthDataContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
    builder.Services.AddScoped<IFilmeService, FilmeService>();

    // Repositories services
    builder.Services.AddScoped<IFilmeRepository, FilmeRepository>();
    builder.Services.AddScoped<INavesEstelaresRepository, NavesEstelaresRepository>();
    builder.Services.AddScoped<IPersonagemRepository, PersonagemRepository>();
    builder.Services.AddScoped<IPlanetaRepository, PlanetaRepository>();
    builder.Services.AddScoped<IVeiculoRepository, VeiculoRepository>();
}

void ConfigureApiServices(WebApplication webApplication)
{
    webApplication.FilmeMapEndpoints();
}