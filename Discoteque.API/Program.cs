using Microsoft.EntityFrameworkCore;
using Discoteque.Data;
using Discoteque.Business.IServices;
using Discoteque.Business.Services;

//create builder especifica que es un API .net 
// var significa que es una variable pero como no se el tipo, puede ser cualquier cosa. 

var builder = WebApplication.CreateBuilder(args);

// Add services to the container. Los builders especifican que necesita la API para funcionar

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//.net necesita clases para funcionar, pero si la ejecucion tiene el mismo nombre que la contiene no es necesario

builder.Services.AddDbContext<DiscotequeContext>(
    // estamos especificando que la base de datos se llama Discoteque
    opt => opt.UseInMemoryDatabase("Discoteque")
);

//Inyeccion de dependencias: se hace en lenguages de alto nivel. AddScopped significa que se instancia solo si yo lo necesita

builder.Services.AddScoped<IArtistService, ArtistService>();

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
