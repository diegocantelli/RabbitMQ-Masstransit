using MassTransit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MasstransitTutorial.Consumers
{
    public class CustomerCreatedConsumer : IConsumer<CustomerCreatedEvent>
    {
        public Task Consume(ConsumeContext<CustomerCreatedEvent> context)
        {
            throw new NotImplementedException();
        }
    }
}
