using System;
using System.Collections.Generic;
using System.Text;

namespace MassTransitTutorial.Domain.Customer.Events
{
    public interface CustomerCreatedEvent
    {
        string CustomerId { get; set; }
        string  Name{ get; set; }
        DateTime Birthdate { get; set; }
        string Type { get; set; }
        DateTime CreatedAt { get; set; }
    }
}
