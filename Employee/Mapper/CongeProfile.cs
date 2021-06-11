using AutoMapper;
using Employee.Entities;
using EventBus.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Mapper
{
    public class CongeProfile : Profile
    {
        public CongeProfile()
        {
            CreateMap<CongeCheckout, CongeCheckoutEvent>().ReverseMap();
        }
    }
}
