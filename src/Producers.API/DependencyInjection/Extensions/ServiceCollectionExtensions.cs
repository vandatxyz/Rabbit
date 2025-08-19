using Api.DependencyInjection.Options;
using MassTransit;
using Data;
using Microsoft.EntityFrameworkCore;

namespace Api.DependencyInjection.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddConfigMasstransitRabbitMQ(this IServiceCollection services, IConfiguration configuration) 
        {
            var masstransitConfiguration = new MasstransitConfiguration();
            configuration.GetSection(nameof(MasstransitConfiguration)).Bind(masstransitConfiguration);
           
            services.AddMassTransit(mt =>
            {
                mt.SetEndpointNameFormatter(new KebabCaseEndpointNameFormatter("api", false));

                mt.AddEntityFrameworkOutbox<ApplicationContext>(o =>
                {
                    o.QueryDelay = TimeSpan.FromSeconds(5);
                    o.UseSqlServer();
                    o.UseBusOutbox();
                });
                mt.UsingRabbitMq((context, bus)=>
                {
                    bus.Host(
                        masstransitConfiguration.Host,
                        masstransitConfiguration.VHost,
                        h =>
                        {
                            h.Username(masstransitConfiguration.UserName ?? "guest");
                            h.Password(masstransitConfiguration.Password ?? "guest");
                        });
                });
            });
            return services;
        }
    }
}
