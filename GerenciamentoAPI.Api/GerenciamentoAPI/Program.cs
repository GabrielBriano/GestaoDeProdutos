using System;
using Microsoft.EntityFrameworkCore;
using GerenciamentoAPI;
using GerenciamentoAPI.Data;

var builder = WebApplication.CreateBuilder(args);

var connectionString = "Host=localhost;Database=ProductDB;Username=postgres;Password=123";
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
