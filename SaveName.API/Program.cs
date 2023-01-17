using Microsoft.EntityFrameworkCore;
using SaveName.API.Data;
using SaveName.API.Repositories;
using SaveName.API.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SaveNameDbContext>
    (options =>
   {
     options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
   });
builder.Services.AddScoped<IPersonRepository, PersonRepository>();
builder.Services.AddDataProtection();
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
