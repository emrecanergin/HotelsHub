using HotelHubApp.API.HotelMapping;
using HotelsHub.API.Application.Abstractions.ExternalCalls.Hotelbeds.HotelApi;
using HotelsHub.API.Application.Abstractions.ExternalCalls.Hotelbeds.RequestBodyGenerators;
using HotelsHub.API.Application.Abstractions.ExternalCalls.HttpRequest;
using HotelsHub.API.Application.Abstractions.HotelMapping;
using HotelsHub.API.Application.Abstractions.RabbitMqClient;
using HotelsHub.API.Application.Abstractions.RedisClient;
using HotelsHub.API.Application.Abstractions.Services;
using HotelsHub.API.Application.Automapper;
using HotelsHub.API.Application.Helpers.Searching;
using HotelsHub.API.Infrastructure.ExternalCalls.Hotelbeds.HotelApi;
using HotelsHub.API.Infrastructure.ExternalCalls.Hotelbeds.HttpRequest;
using HotelsHub.API.Infrastructure.ExternalCalls.Hotelbeds.RequestGenerators;
using HotelsHub.API.Infrastructure.Helpers.Searching;
using HotelsHub.API.Persistence.RabbitMqClient;
using HotelsHub.API.Persistence.RedisService;
using HotelsHub.API.Persistence.Services;

namespace HotelsHub.API.Extensions
{
    public static class RegistirationExtension
    {
        public static IServiceCollection AddProjectServices(this IServiceCollection services, IConfiguration configuration)
        {
            //redis classes 
            services.AddSingleton<RedisServer>();
            services.AddSingleton<IRedisService, RedisService>();

            //rabbitmq
            services.AddSingleton<IRabbitMqService,RabbitMqService>();
            services.AddSingleton<IPublisherService, PublisherService>();

            //search classes
            services.AddScoped<ISearchService, SearchService>();
            services.AddScoped<ISearchOperations, SearchOperations>();
            services.AddScoped<IAvailabilityRequestGenerator, AvailabilityRequestGenerator>();
            services.AddScoped<IAvailabilityClient, AvailabilityClient>();

            //mapping
            services.AddScoped<IResponseMap, ResponseMap>();

            //one interface multiple registiration,this line must be refactoring!!!
            services.AddScoped<IHttpRequestService, HotelbedsHttpRequestService>();


            services.AddAutoMapper(config => config.AddProfile(new MappingProfile()));
            services.AddHttpClient();
            return services;

        }
    }
}
