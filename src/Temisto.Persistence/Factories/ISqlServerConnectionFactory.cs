using System.Data;

namespace Temisto.Persistence.Factories
{
    public interface ISqlServerConnectionFactory
    {
        Task<IDbConnection> GetOpenConnectionAsync();
    }
}
