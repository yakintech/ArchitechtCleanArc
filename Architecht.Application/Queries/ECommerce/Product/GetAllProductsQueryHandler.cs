using Architecht.Application.DTO;
using Architecht.Infrastructure.UnitOfWork;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecht.Application.Queries.ECommerce.Product
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<GetAllProductsDto>>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetAllProductsQueryHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<List<GetAllProductsDto>> Handle(GetAllProductsQuery request,CancellationToken cancellationToken)
        {
            
            var products = unitOfWork.ProductRepository.GetAll(["Category"]);//Include Category (Eager Loading
            var productsDto = new List<GetAllProductsDto>();
            foreach (var product in products)
            {
                productsDto.Add(new GetAllProductsDto
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    CategoryId = product.CategoryId ?? Guid.Empty,
                    CategoryName = product.Category?.Name
                });
            }
            return productsDto;
        }

    }
}
