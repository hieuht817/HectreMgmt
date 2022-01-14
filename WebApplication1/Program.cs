using HectreMgmt.Domain.Model;
using HectreMgmt.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(option =>
    option.UseInMemoryDatabase("HectreMgmtInMemDB"));

builder.Services.AddScoped<ChemicalRepo>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseMigrationsEndPoint();

}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
