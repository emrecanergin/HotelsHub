using HotelsHub.API.Domain.Models.HotelbedsModel.auto.messages.requests.availability;
using HotelsHub.API.Domain.Models.HotelsHubApiModel.messages;

namespace HotelsHub.API.Application.Abstractions.ExternalCalls.Hotelbeds.RequestBodyGenerators
{
    public interface IAvailabilityRequestGenerator
    {
        public AvailabilityRQ CreateAvailabilityRequestBody(SearchRequest searchRequest);
    }
}
