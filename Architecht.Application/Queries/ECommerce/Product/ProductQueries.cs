using Architecht.Application.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecht.Application.Queries.ECommerce.Product
{
    public class GetAllProductsQuery : IRequest<List<GetAllProductsDto>>
    {
    }


    public class GetProductByIdQuery : IRequest<GetProductByIdDto>
    {
        public Guid Id { get; set; }
    }
}
