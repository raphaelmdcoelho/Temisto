using Moq;
using System.Collections.Generic;
using Temisto.Broker;
using Temisto.Domain.Models;
using Temisto.Importer.Provider;
using Temisto.Importer.Services;
using Xunit;

namespace Temisto.Importer.Tests.Services
{
    public class ImporterServiceTests
    {
        [Fact]
        public void ImportHero_should_get_a_list_of_heros_and_send_to_broker_queue()
        {
            var herosStub = new List<HeroDTO>
            {
                new HeroDTO()
            };

            var documentProviderMock = new Mock<IDocumentProvider>();

            documentProviderMock
                .Setup(dp => dp.GetHero())
                .Returns(herosStub)
                .Verifiable();

            var sendMessageServiceMock = new Mock<ISendMessageService>();

            sendMessageServiceMock
                .Setup(sm => sm.Send(herosStub))
                .Verifiable();

            var subject = new ImporterService(documentProviderMock.Object, sendMessageServiceMock.Object);
            subject.Run();

            documentProviderMock.Verify();
            sendMessageServiceMock.Verify();
        }
    }
}
