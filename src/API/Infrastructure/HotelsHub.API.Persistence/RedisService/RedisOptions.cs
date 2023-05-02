using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelsHub.API.Persistence.RedisService
{
    public class RedisOptions
    {
        public string Configuration { get; set; }
        public ConfigurationOptions ConfigurationOptions { get; set; }
        public object InstanceName { get; set; }
    }
}
