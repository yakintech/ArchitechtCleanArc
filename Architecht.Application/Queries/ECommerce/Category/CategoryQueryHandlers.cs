using Architecht.Application.DTO;
using Architecht.Infrastructure.UnitOfWork;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecht.Application.Queries.ECommerce.Category
{
    public class GetAllCategoriesQueryHandler : IRequestHandler<GetAllCategoriesQuery, List<GetAllCategoriesDto>>
    {

        private IUnitOfWork unitOfWork;

        public GetAllCategoriesQueryHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }


        public async Task<List<GetAllCategoriesDto>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            var categories = unitOfWork.CategoryRepository.GetAll();
            var result = categories.Select(c => new GetAllCategoriesDto
            {
                Id = c.Id,
                Name = c.Name
            }).ToList();

            return result;
           
        }


    }



    public class GetCategoryByIdQueryHandler : IRequestHandler<GetCategoryByIdQuery, GetCategoryByIdDto>
    {
        private IUnitOfWork unitOfWork;

        public GetCategoryByIdQueryHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<GetCategoryByIdDto> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var category = unitOfWork.CategoryRepository.GetById(request.Id);
            var result = new GetCategoryByIdDto
            {
                Id = category.Id,
                Name = category.Name
            };

            return result;
        }
    }


    public class GetCategoriesWithPaginationQueryHandler : IRequestHandler<GetCategoriesWithPaginationQuery, List<GetAllCategoriesDto>>
    {
        private IUnitOfWork unitOfWork;

        public GetCategoriesWithPaginationQueryHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<List<GetAllCategoriesDto>> Handle(GetCategoriesWithPaginationQuery request, CancellationToken cancellationToken)
        {
            var categories = unitOfWork.CategoryRepository.GetAll(request.Page, request.PageSize);
            var result = categories.Select(c => new GetAllCategoriesDto
            {
                Id = c.Id,
                Name = c.Name
            }).ToList();

            return result;
        }
    }   
}
