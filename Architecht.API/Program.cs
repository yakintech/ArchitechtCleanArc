using Architecht.API.Extensions;
using Architecht.Application.Commands;
using Architecht.Application.Queries;
using Architecht.Infrastructure.EF;
using Architecht.Infrastructure.Repositories.ECommerce;
using Architecht.Infrastructure.UnitOfWork;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ArchitechtContext>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddMediatRHandlers();
builder.Services.AddRepositories();

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
