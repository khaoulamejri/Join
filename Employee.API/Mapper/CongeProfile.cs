using AutoMapper;
using Employee.Domain.Entities;
using EventBus.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.API.Mapper
{
    public class CongeProfile : Profile
    {
        public CongeProfile()
        {
            CreateMap<CongeCheckout, CongeCheckoutEvent>().ReverseMap();
        }
    }
}
