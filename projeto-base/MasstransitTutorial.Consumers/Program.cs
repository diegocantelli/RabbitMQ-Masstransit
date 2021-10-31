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
                cfg.ReceiveEndpoint("");
            });
        }
    }
}
