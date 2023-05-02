using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelsHub.API.Application.Abstractions.RedisClient
{
    public interface IRedisService
    {
        T GetJsonData<T>(string key);
        string GetValue(string key);
        void Add(string key, string value);
        void Remove(string key);
        void Clear();
        bool Any(string key);
    }
}
