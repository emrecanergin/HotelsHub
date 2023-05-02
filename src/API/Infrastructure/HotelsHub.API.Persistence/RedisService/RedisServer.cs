using Microsoft.Extensions.Options;
using StackExchange.Redis;

namespace HotelsHub.API.Persistence.RedisService
{
    public class RedisServer
    {
        private readonly ConnectionMultiplexer _connectionMultiplexer;
        private readonly IOptions<RedisOptions> _redisOptions;

        public RedisServer(IOptions<RedisOptions> redisOptions)
        {
            _redisOptions = redisOptions;
            _connectionMultiplexer = ConnectionMultiplexer.Connect("localhost:6379,abortConnect=false");
        }

        public StackExchange.Redis.IDatabase Database(int databaseId)
        {
            return _connectionMultiplexer.GetDatabase(databaseId);

        }
        public void FlushDatabase(int databaseId)
        {
            _connectionMultiplexer.GetServer(_redisOptions.Value.Configuration).FlushDatabase(databaseId);
        }

        public ConfigurationOptions CreateRedisConfigurationOptions()
        {
            var config = _redisOptions.Value.ConfigurationOptions;
            return config;
        }
    }
}
