using HotelsHub.API.Application.Abstractions.RabbitMqClient;
using RabbitMQ.Client;
using System.Text;
using System.Text.Json;

namespace HotelsHub.API.Persistence.RabbitMqClient
{
    public class PublisherService : IPublisherService
    {
        private readonly IRabbitMqService _rabbitMqService;

        public PublisherService(IRabbitMqService rabbitMqService)
        {
            _rabbitMqService = rabbitMqService;
        }

        public bool SendData<T>(string queueName, T data)
        {
            try
            {
                var connection = _rabbitMqService.GetConnection();
                var channel = connection.CreateModel();
                channel.QueueDeclare(queue: queueName,
                                        durable: false,
                                        exclusive: false,
                                        autoDelete: false,
                                        arguments: null);

                //string message = JsonConvert.SerializeObject(data);
                string message = JsonSerializer.Serialize(data);
                var body = Encoding.UTF8.GetBytes(message);

                channel.BasicPublish(exchange: "",
                                       routingKey: queueName,
                                       basicProperties: null,
                                       body: body);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
