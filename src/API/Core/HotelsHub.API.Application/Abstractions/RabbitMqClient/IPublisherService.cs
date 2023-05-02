namespace HotelsHub.API.Application.Abstractions.RabbitMqClient
{
    public interface IPublisherService
    {
        bool SendData<T>(string queueName, T data);
    }
}
