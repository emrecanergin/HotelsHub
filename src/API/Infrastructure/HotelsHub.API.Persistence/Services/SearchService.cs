using HotelsHub.API.Application.Abstractions.ExternalCalls.Hotelbeds.HotelApi;
using HotelsHub.API.Application.Abstractions.ExternalCalls.Hotelbeds.RequestBodyGenerators;
using HotelsHub.API.Application.Abstractions.RabbitMqClient;
using HotelsHub.API.Application.Abstractions.RedisClient;
using HotelsHub.API.Application.Abstractions.Services;
using HotelsHub.API.Application.Helpers.Searching;
using HotelsHub.API.Application.Results;
using HotelsHub.API.Domain.Helper;
using HotelsHub.API.Domain.Models.HotelsHubApiModel.messages;
using System.Text.Json;

namespace HotelsHub.API.Persistence.Services
{
    public class SearchService : ISearchService
    {
        private readonly IRedisService _redisService;
        private readonly IPublisherService _publisherService;
        private readonly ISearchOperations _searchOperations;
        private readonly IAvailabilityClient _availabilityClient;
        private readonly IAvailabilityRequestGenerator _availabilityRequestGenerator;



        public SearchService(ISearchOperations searchOperations,
                             IRedisService redisService,
                             IAvailabilityClient availabilityClient,
                             IAvailabilityRequestGenerator availabilityRequestGenerator,
                             IPublisherService publisherService)
        {
            _searchOperations = searchOperations;
            _redisService = redisService;
            _availabilityClient = availabilityClient;
            _availabilityRequestGenerator = availabilityRequestGenerator;
            _publisherService = publisherService;
        }

        public async Task<Result<SearchResponse>> Search(SearchRequest searchRequest)
        {
            var key = ComputeSHA256.ComputeSha256Hash(JsonSerializer.Serialize(searchRequest));
            SearchResponse searchResponse = new();


            if (!_redisService.Any(key))
            {
                var rb = _availabilityRequestGenerator.CreateAvailabilityRequestBody(searchRequest);
                var response = await _availabilityClient.GetAvailability(rb);
                searchResponse.Hotels = _searchOperations.GetMappedHotels(response, searchRequest);
                //save as compressed response data
                _redisService.Add(key, JsonSerializer.Serialize(searchResponse));
            }
            else
            {
                var responseFromCache = _redisService.GetJsonData<SearchResponse>(key);
                _publisherService.SendData<SearchResponse>("log", responseFromCache);
                return new Result<SearchResponse>(responseFromCache, true);

            }

            _publisherService.SendData<SearchResponse>("log", searchResponse);

            return new Result<SearchResponse>(searchResponse, true);           
        }
    }
}
