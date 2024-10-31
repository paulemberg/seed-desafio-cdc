using System.ComponentModel.DataAnnotations;
using LojaVirtual.Author;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    
}

app.UseHttpsRedirection();


app.MapPost("/author", async ([FromBody] AuthorDto dto) =>
{
    Validator.ValidateObject(dto, new ValidationContext(dto));
    return Results.Ok("Autor Criado com Sucesso!");
}).WithOpenApi();

app.Run();
