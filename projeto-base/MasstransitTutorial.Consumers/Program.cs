using MassTransit;
using System;

namespace MasstransitTutorial.Consumers
{
    class Program
    {
        static void Main(string[] args)
        {
            var busControl = Bus.Factory.CreateUsingRabbitMq(cfg =>
            {
                cfg.ReceiveEndpoint("greet-new-costumers", cfg => 
                {
                    // aqui deve ser passada a classe que implementa a interface IConsumer do Masstransit   
                    cfg.Consumer<CustomerCreatedConsumer>();
                });
            });

            busControl.Start();

            while (true) ;
        }
    }
}
