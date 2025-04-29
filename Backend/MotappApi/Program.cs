using MotappApi.Data;
using MotappApi.Repositories;
using MotappApi.Repositories.Interfaces;
using MotappApi.Services;
using MotappApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Banco de dados
builder.Services.AddDbContext<MotappDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Injeção de dependência
builder.Services.AddScoped<IMotoService, MotoService>();
builder.Services.AddScoped<IMotoRepository, MotoRepository>();

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();
