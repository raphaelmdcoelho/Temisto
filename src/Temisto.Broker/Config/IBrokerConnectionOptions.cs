namespace Temisto.Broker.Config
{
    public interface IBrokerConnectionOptions
    {
        public string? HostName { get; set; }
        public string? User { get; set; }
        public string? Password { get; set; }
        public string? Queue { get; set; }
        public string? Exchanger { get; set; }
        public string? durable { get; set; }
        public string? exclusive { get; set; }
        public string? autoDelete { get; set; }
        public string? arguments { get; set; }
    }
}
