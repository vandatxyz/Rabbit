using Comsumer.API.DependencyInjection.Options;
using Comsumer.API.MessageBus.Consumers.Events;
using MassTransit;
using System.Reflection;
using Data;
using Microsoft.EntityFrameworkCore;

namespace Comsumer.API.DependencyInjection.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddConfigMasstransitRabbitMQ(this IServiceCollection services, IConfiguration configuration)
        {
            var masstransitConfiguration = new MasstransitConfiguration();
            configuration.GetSection(nameof(MasstransitConfiguration)).Bind(masstransitConfiguration);
            services.AddMassTransit(mt =>
            {
                mt.AddConsumers(Assembly.GetExecutingAssembly());
                mt.UsingRabbitMq((context, bus) =>
                {
                    bus.Host(
                        masstransitConfiguration.Host,
                        masstransitConfiguration.VHost,
                        h =>
                        {
                            h.Username(masstransitConfiguration.UserName ?? "guest");
                            h.Password(masstransitConfiguration.Password ?? "guest");
                        });

                    bus.ConfigureEndpoints(context);
                });
            });
            return services;
        }
    }
}
