﻿using HotelsHub.API.Application.Abstractions.RedisClient;
using System.Text.Json;

namespace HotelsHub.API.Persistence.RedisService
{
    public class RedisService : IRedisService
    {
        RedisServer _redisServer;
        public RedisService(RedisServer redisServer)
        {
            _redisServer = redisServer;
        }
        public void Add(string key, string value)
        {
            _redisServer.Database(0).StringSet(key, value);
        }

        public bool Any(string key)
        {
            return _redisServer.Database(0).KeyExists(key);
        }

        public void Clear()
        {
            _redisServer.FlushDatabase(0);
        }

        public T GetJsonData<T>(string key)
        {
            if (Any(key))
            {
                var jsonData = _redisServer.Database(0).StringGet(key);
                return JsonSerializer.Deserialize<T>(jsonData);
            }
            return default;
        }

        public string GetValue(string key)
        {
            return _redisServer.Database(0).StringGet(key);
        }

        public void Remove(string key)
        {
            _redisServer.Database(0).KeyDelete(key);
        }
    }
}
