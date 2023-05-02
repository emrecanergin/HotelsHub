using HotelsHub.API.Application.Abstractions.RabbitMqClient;
using RabbitMQ.Client;
using RabbitMQ.Client.Exceptions;

namespace HotelsHub.API.Persistence.RabbitMqClient
{
    public class RabbitMqService : IRabbitMqService
    {
        public IConnection GetConnection()
        {
            try
            {
                var factory = new ConnectionFactory()
                {
                    Uri = new Uri("*"),
                };

                return factory.CreateConnection();
            }
            catch (BrokerUnreachableException)
            {
                // return GetConnection();
                throw new Exception("rabbitmq");
            }
        }

        public IModel GetModel(IConnection connection)
        {
            return GetConnection().CreateModel();
        }
    }
}
