using System;
using System.Collections.Generic;
using System.Text;

namespace MasstransitTutorial.Consumers
{
    public interface CustomerCreatedEvent
    {
        string CustomerId { get; }
        string Name { get; }
        DateTime Birthdate { get; }
        string Type { get; }
        DateTime CreatedAt { get; }
    }
}
