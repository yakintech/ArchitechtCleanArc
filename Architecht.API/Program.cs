using Architecht.Application.Commands;
using Architecht.Application.Queries.ECommerce.Category;
using Architecht.Infrastructure.EF;
using Architecht.Infrastructure.Repositories.ECommerce;
using Architecht.Infrastructure.UnitOfWork;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ArchitechtContext>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddMediatR(opt =>
{
    opt.RegisterServicesFromAssemblyContaining<GetAllCategoriesQueryHandler>();
    opt.RegisterServicesFromAssemblyContaining<GetCategoryByIdQueryHandler>();
    opt.RegisterServicesFromAssemblyContaining<CreateCategoryCommandHandler>();
    opt.RegisterServicesFromAssemblyContaining<UpdateCategoryCommandHandler>();
    opt.RegisterServicesFromAssemblyContaining<DeleteCategoryCommandHandler>();
    opt.RegisterServicesFromAssemblyContaining<GetCategoriesWithPaginationQueryHandler>();
});

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

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
