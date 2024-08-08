using Architecht.Application.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecht.Application.Commands
{

    public class CreateCategoryCommand : IRequest<CreateCategoryResponse>
    {
        public string Name { get; set; }
    }

    public class CreateCategoryResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }


    }



    public class UpdateCategoryCommand : IRequest<UpdateCategoryResponse>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class UpdateCategoryResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public DateTime UpdatedAt { get; set; }
    }


    public class DeleteCategoryCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
    }





}
