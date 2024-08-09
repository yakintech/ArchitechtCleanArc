using Architecht.Application.DTO;
using Architecht.Application.Exceptions;
using Architecht.Infrastructure.UnitOfWork;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecht.Application.Queries.ECommerce.Product
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductByIdDto>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetProductByIdQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task<GetProductByIdDto> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = _unitOfWork.ProductRepository.GetById(request.Id);
            if (product == null)
            {
                throw new DataNotFoundException(request.Id + " product not found");
            }
            return new GetProductByIdDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Stock = product.Stock,
                CategoryId = product.CategoryId ?? Guid.Empty,
                CategoryName = product.Category?.Name
            };
        }

    }
}
