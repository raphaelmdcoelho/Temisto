using RabbitMQ.Client;

namespace Temisto.Broker
{
    public interface IBrokerConnectionFactory
    {
        IConnectionFactory GetConnectionFactory();
    }
}
