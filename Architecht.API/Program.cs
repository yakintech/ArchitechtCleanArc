using Architecht.API.Extensions;
using Architecht.API.Middleware;
using Architecht.Application.Commands;
using Architecht.Application.DTO;
using Architecht.Application.Queries;
using Architecht.Application.Validators;
using Architecht.Infrastructure.EF;
using Architecht.Infrastructure.Repositories.ECommerce;
using Architecht.Infrastructure.UnitOfWork;
using FluentValidation;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ArchitechtContext>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddMediatRHandlers();
builder.Services.AddRepositories();
builder.Services.AddValidations();
builder.Services.AddMappings();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.UseMiddleware<ExceptionMiddleware>();

app.UseAuthorization();

app.MapControllers();

app.Run();
