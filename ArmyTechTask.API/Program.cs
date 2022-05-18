using System.Reflection;
using ArmyTechTask.Application;
using ArmyTechTask.Persistence;
using FluentValidation.AspNetCore;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(option =>
{

}).AddFluentValidation(options =>
    options.RegisterValidatorsFromAssemblies(new List<Assembly>() { typeof(ApplicationLayer).Assembly }));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMediatR(typeof(ApplicationLayer).Assembly);

builder.Services.AddAutoMapper(typeof(ApplicationLayer).Assembly);

builder.Services.AddDbContext<ArmyTechTaskContext>();

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