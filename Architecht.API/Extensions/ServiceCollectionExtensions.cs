using Architecht.Application.Commands;
using Architecht.Application.Queries;
using Architecht.Infrastructure.Repositories.ECommerce;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecht.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            return services;
        }


        public static IServiceCollection AddMediatRHandlers(this IServiceCollection services)
        {
            services.AddMediatR(opt =>
            {
                opt.RegisterServicesFromAssemblyContaining<GetAllCategoriesQueryHandler>();
                opt.RegisterServicesFromAssemblyContaining<GetCategoryByIdQueryHandler>();
                opt.RegisterServicesFromAssemblyContaining<CreateCategoryCommandHandler>();
                opt.RegisterServicesFromAssemblyContaining<UpdateCategoryCommandHandler>();
                opt.RegisterServicesFromAssemblyContaining<DeleteCategoryCommandHandler>();
                opt.RegisterServicesFromAssemblyContaining<GetCategoriesWithPaginationQueryHandler>();
            });

            return services;
        }   
    }
}
