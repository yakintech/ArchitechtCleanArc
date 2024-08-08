using Architecht.Infrastructure.UnitOfWork;
using MediatR;
using Architecht.Domain.Models;


namespace Architecht.Application.Commands
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, CreateCategoryResponse>
    {

        private readonly IUnitOfWork _unitOfWork;

        public CreateCategoryCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task<CreateCategoryResponse> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = new Category
            {
                Name = request.Name
            };

            _unitOfWork.CategoryRepository.Create(category);
            _unitOfWork.SaveChanges();

            var response = new CreateCategoryResponse();
            response.Id = category.Id;
            response.Name = category.Name;

            return response;



        }
    }

    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, UpdateCategoryResponse>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateCategoryCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<UpdateCategoryResponse> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = _unitOfWork.CategoryRepository.GetById(request.Id);
            category.Name = request.Name;


            if (category == null)
                throw new Exception("Category not found");
            else
                _unitOfWork.CategoryRepository.Update(category);

            _unitOfWork.SaveChanges();

            var response = new UpdateCategoryResponse();
            response.Id = category.Id;
            response.Name = category.Name;
            response.UpdatedAt = category.UpdatedAt;

            return response;
        }
    }

    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand, Guid>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteCategoryCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = _unitOfWork.CategoryRepository.GetById(request.Id);
            _unitOfWork.CategoryRepository.Delete(category.Id);
            _unitOfWork.SaveChanges();

            return category.Id;
        }
    }
}
