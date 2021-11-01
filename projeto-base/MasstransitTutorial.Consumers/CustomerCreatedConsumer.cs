using MassTransit;
using MassTransitTutorial.Domain.Customer.Events;
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
            Console.WriteLine($"Novo cliente cadastrado: ${context.Message.Name}");

            return Task.CompletedTask;
        }
    }
}
