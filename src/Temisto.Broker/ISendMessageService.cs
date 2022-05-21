using Temisto.Domain.Models;

namespace Temisto.Broker
{
    public interface ISendMessageService
    {
        void Send(IEnumerable<HeroDTO> heroes);
    }
}
