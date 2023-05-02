using HotelsHub.API.Domain.Models.HotelbedsModel.auto.messages.responses.availability;
using HotelsHub.API.Domain.Models.HotelsHubApiModel.messages;
using HotelsHub.API.Domain.Models.HotelsHubApiModel.model;

namespace HotelsHub.API.Application.Helpers.Searching
{
    public interface ISearchOperations
    {
        public List<Hotel> GetMappedHotels(AvailabilityRS response, SearchRequest request);
    }
}
