using AutoMapper;
using Conge.Entities;
using EventBus.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conge.Mapping
{
    public class OrderingProfile : Profile
    {
        public OrderingProfile()
        {
            CreateMap<CheckoutCongeCommand, CongeCheckoutEvent>().ReverseMap();
        }
    }
}
