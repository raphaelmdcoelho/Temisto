using Temisto.Broker;
using Temisto.Importer.Provider;

namespace Temisto.Importer.Services
{
    public class ImporterService : IImporterService
    {
        private readonly IDocumentProvider _documentProvider;
        private readonly ISendMessageService _sendMessageService;

        public ImporterService(IDocumentProvider documentProvider, ISendMessageService sendMessageService)
        {
            _documentProvider = documentProvider;
            _sendMessageService = sendMessageService;
        }

        public void Run()
        {
            var heroes = _documentProvider.GetHero().ToList();

            _sendMessageService.Send(heroes);
        }
    }
}
