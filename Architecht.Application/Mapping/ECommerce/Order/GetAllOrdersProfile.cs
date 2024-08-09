using Architecht.Application.DTO;
using Architecht.Domain.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecht.Application.Mapping
{
    public class GetAllOrdersProfile : Profile
    {
        public GetAllOrdersProfile()
        {
            CreateMap<Order, GetAllOrdersDto>();
        }
    }
}
