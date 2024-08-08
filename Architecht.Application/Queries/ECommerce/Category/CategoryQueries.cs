using Architecht.Application.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecht.Application.Queries
{
    public class GetAllCategoriesQuery : IRequest<List<GetAllCategoriesDto>>
    {
    }

    public class GetCategoryByIdQuery : IRequest<GetCategoryByIdDto>
    {
        public Guid Id { get; set; }
    }   

    public class GetCategoriesWithPaginationQuery : IRequest<List<GetAllCategoriesDto>>
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
