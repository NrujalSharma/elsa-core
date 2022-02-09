using System;
using System.Threading;
using System.Threading.Tasks;
using Elsa.Activities.RabbitMq.Configuration;
using Rebus.Messages;

namespace Elsa.Activities.RabbitMq.Services
{
    public interface IClient
    {
        RabbitMqBusConfiguration Configuration { get; }
        void SubscribeWithHandler(Func<TransportMessage, CancellationToken, Task> handler);
        Task PublishMessage(string message);
        void Dispose();
    }
}