using RabbitMQ.Client;
using Temisto.Broker.Config;

namespace Temisto.Broker
{
    public class BrokerConnectionFactory : IBrokerConnectionFactory
    {
        private readonly IBrokerConnectionOptions _brokerConnectionOptions;

        public BrokerConnectionFactory(IBrokerConnectionOptions brokerConnectionOptions)
        {
            _brokerConnectionOptions = brokerConnectionOptions;
        }

        public IConnectionFactory GetConnectionFactory()
        {
            return new ConnectionFactory
            {
                HostName = _brokerConnectionOptions.HostName,
                UserName = _brokerConnectionOptions.User,
                Password = _brokerConnectionOptions.Password
            };
        }
    }
}
