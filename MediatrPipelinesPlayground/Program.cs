using MediatrPipelinesPlayground.Database;
using MediatrPipelinesPlayground.Handlers;
using MediatrPipelinesPlayground.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMediatR(config => config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

// weather forecast services
builder.Services.AddTransient<GetWeatherForecastHandler>();
builder.Services.AddSingleton<WeatherForecastRepository>();

builder.Services.AddDbContext<WeatherDbContext>(options =>
        options.UseNpgsql(builder.Configuration.GetConnectionString("SamplePostgresUnsecureConnectionString"))); // replace with an actual connection string

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
