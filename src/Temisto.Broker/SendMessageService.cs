using Newtonsoft.Json;
using System.Text;
using Temisto.Broker.Config;
using Temisto.Domain.Models;

namespace Temisto.Broker
{
    public class SendMessageService : ISendMessageService
    {
        private readonly IBrokerConnectionFactory _connectionFactory;
        private readonly IBrokerConnectionOptions _brokerConnectionOptions;

        public SendMessageService(IBrokerConnectionFactory connectionFactory, IBrokerConnectionOptions brokerConnectionOptions)
        {
            _connectionFactory = connectionFactory;
            _brokerConnectionOptions = brokerConnectionOptions;
        }

        public void Send(IEnumerable<HeroDTO> heroes)
        {
            var connectionFactory = _connectionFactory.GetConnectionFactory();
            using var connection = connectionFactory.CreateConnection();
            using var channel = connection.CreateModel();

            var message = JsonConvert.SerializeObject(heroes);
            var byteMessage = Encoding.UTF8.GetBytes(message);

            channel.BasicPublish(
                    exchange: _brokerConnectionOptions.Exchanger,
                    routingKey: "",
                    mandatory: true,
                    basicProperties: null,
                    body: byteMessage);
        }
    }
}
