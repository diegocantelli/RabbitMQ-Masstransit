using MassTransit;
using MassTransitTutorial.Domain.Customer.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MasstransitTutorial.Consumers
{
    public class AddToMaillistConsumer : IConsumer<CustomerCreatedEvent>
    {
        public Task Consume(ConsumeContext<CustomerCreatedEvent> context)
        {
            Console.WriteLine($"Email do usuário {context.Message.Name} foi adicionado à lista.");

            return Task.CompletedTask;
        }
    }
}
