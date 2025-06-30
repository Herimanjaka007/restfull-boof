using MadaResto.Application.Repositories;
using MadaResto.Application.Services;
using MadaResto.Infrastructure.Persistence;
using MadaResto.Infrastructure.Repositories;
using MadaResto.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddDbContext<MadaRestoDbContext>(options =>
    options.UseInMemoryDatabase("MadaRestoDb"));
builder.Services.AddScoped<ICulinaryExperienceRepository, CulinaryExperienceRepository>();
builder.Services.AddScoped<ICulinaryExperienceService, CulinaryExperienceService>();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.Run();
