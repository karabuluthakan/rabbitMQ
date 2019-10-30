using Microsoft.Extensions.DependencyInjection;
using RabbitMQ.Domain.Core.Bus;
using RabbitMQ.Infrastructer.Bus;

namespace RabbitMQ.Infrastructer.IoC
{
    public class DependencyResolver
    {
        public static void Load(IServiceCollection services)
        {
            services.AddTransient<IEventBus,RabbitMqBus>();
        }
    }
}