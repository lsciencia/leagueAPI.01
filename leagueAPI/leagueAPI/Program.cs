using leagueAPI.Helper;
using leagueAPI.Repositories;
using leagueAPI.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var keyValue = builder.Configuration.GetSection("SecretKey").GetSection("KEY").Value;
SecretKey.KEY = keyValue;

builder.Services.AddScoped<ICommunicator, Communicator>();
builder.Services.AddScoped<ISummonerRepository, SummonerRepository>();

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
