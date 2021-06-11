using AutoMapper;
using EventBus.Event;
using MassTransit;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace Conge.EventBusConsumer
{
    public class CongeCheckoutConsumer : IConsumer<CongeCheckoutEvent>
    {
       private readonly IMediator _mediator;
        private readonly IMapper _mapper;
       private readonly ILogger<CongeCheckoutConsumer> _logger;

        public CongeCheckoutConsumer(IMediator mediator, IMapper mapper, ILogger<CongeCheckoutConsumer> logger )
        {
            _mediator = mediator;
            _mapper = mapper;
            _logger = logger;
        }

        public Task Consume(ConsumeContext<CongeCheckoutEvent> context)
        {
            throw new NotImplementedException();
            //var command = _mapper.Map<CheckoutCongeCommand>(context.Message);
            //var result = await _mediator.Send(command);
        }
    }
}
