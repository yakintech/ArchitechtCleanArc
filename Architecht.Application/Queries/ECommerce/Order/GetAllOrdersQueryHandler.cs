using Architecht.Application.DTO;
using Architecht.Infrastructure.UnitOfWork;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecht.Application.Queries
{
    public class GetAllOrdersQueryHandler : IRequestHandler<GetAllOrdersQuery, List<GetAllOrdersDto>>
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllOrdersQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<GetAllOrdersDto>> Handle(GetAllOrdersQuery request, System.Threading.CancellationToken cancellationToken)
        {
            var orders = _unitOfWork.OrderRepository.GetAll();


            // autoMapper kullanarak islemi kisalttik
            var response = _mapper.Map<List<GetAllOrdersDto>>(orders);


            // Automapper onceki hali
            //var response = new List<GetAllOrdersDto>();

            //foreach (var order in orders)
            //{
            //    response.Add(new GetAllOrdersDto
            //    {
            //        OrderNumber = order.OrderNumber,
            //        RequiredDate = order.RequiredDate,
            //        ShippedDate = order.ShippedDate,
            //        Address = order.Address
            //    });
            //}

            return response;
        }

    }
}
