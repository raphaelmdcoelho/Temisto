using Microsoft.Extensions.DependencyInjection;

namespace Temisto.Broker.Extensions
{
    public static class DependencyInjection
    {
        public static void ConfigureBrokerServices(this IServiceCollection services)
        {
            services.AddScoped<IBrokerConnectionFactory, BrokerConnectionFactory>();
            services.AddScoped<ISendMessageService, SendMessageService>();
        }
    }
}
