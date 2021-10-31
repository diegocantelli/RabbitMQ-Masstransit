using System;
using System.Collections.Generic;
using System.Text;

namespace MassTransitTutorial.Domain.Customer.Events
{
    public interface CustomerCreatedEvent
    {
        string CustomerId { get; }
        string  Name{ get; }
        DateTime Birthdate { get; }
        string Type { get; }
        DateTime CreatedAt { get; }
    }
}
