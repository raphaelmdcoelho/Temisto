using Temisto.Domain.Models;

namespace Temisto.Importer.Provider
{
    public interface IDocumentProvider
    {
        IEnumerable<HeroDTO> GetHero();
    }
}
