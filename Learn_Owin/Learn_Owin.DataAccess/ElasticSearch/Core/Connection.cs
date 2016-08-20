using Nest;
using System;

namespace Learn_Owin.DataAccess
{
    public static class Connection
    {
        private static Lazy<IElasticClient> _client => new Lazy<IElasticClient>(() => GetConnection());

        public static IElasticClient Client => _client.Value;

        private static IElasticClient GetConnection()
        {
            var node = new Uri("https://df763f70249eb534780bd0acff9c4bc0.us-east-1.aws.found.io:9243");
            var settings = new ConnectionSettings(node);
            var client = new ElasticClient(settings);
            return client;
        }
    }
}
