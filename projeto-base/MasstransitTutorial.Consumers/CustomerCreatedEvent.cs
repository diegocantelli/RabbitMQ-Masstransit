using System;
using System.Collections.Generic;
using System.Text;

// o name space tem que ser o mesmo da aplicação que está publicando, pois o RabbitMQ usa o namespace para nomear os exchanges
// e para configurar as filas
// TODO: verificar uma forma de não usar o namespace para essa configuração
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
