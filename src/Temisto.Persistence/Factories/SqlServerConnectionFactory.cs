using System.Data;

namespace Temisto.Persistence.Factories
{
    public class SqlServerConnectionFactory : ISqlServerConnectionFactory
    {
        private readonly string _connectionString;

        public SqlServerConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Task<IDbConnection> GetOpenConnectionAsync()
        {
            throw new NotImplementedException();
        }
    }
}
