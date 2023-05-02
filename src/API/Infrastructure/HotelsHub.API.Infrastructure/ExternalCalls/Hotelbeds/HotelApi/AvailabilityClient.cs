using HotelsHub.API.Application.Abstractions.ExternalCalls.Hotelbeds.HotelApi;
using HotelsHub.API.Application.Abstractions.ExternalCalls.HttpRequest;
using HotelsHub.API.Domain.Models.HotelbedsModel.auto.messages.requests.availability;
using HotelsHub.API.Domain.Models.HotelbedsModel.auto.messages.responses.availability;
using Newtonsoft.Json;

namespace HotelsHub.API.Infrastructure.ExternalCalls.Hotelbeds.HotelApi
{
    public class AvailabilityClient : IAvailabilityClient
    {
        private const string TARGET = "https://api.test.hotelbeds.com/hotel-api/1.0/hotels";

        private readonly IHttpRequestService _httpRequestService;
        public AvailabilityClient(IHttpRequestService httpRequestService)
        {
            _httpRequestService = httpRequestService;
        }
        public async Task<AvailabilityRS> GetAvailability(AvailabilityRQ availabilityRQ)
        {
            var data = await _httpRequestService.PostRequestAsync(availabilityRQ, TARGET);
            return JsonConvert.DeserializeObject<AvailabilityRS>(data);
        }
    }
}
