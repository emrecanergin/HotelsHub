using RabbitMQ.Client;
using IModel = RabbitMQ.Client.IModel;

namespace HotelsHub.API.Application.Abstractions.RabbitMqClient
{
    public interface IRabbitMqService
    {
        IConnection GetConnection();
        IModel GetModel(IConnection connection);
    }
}
