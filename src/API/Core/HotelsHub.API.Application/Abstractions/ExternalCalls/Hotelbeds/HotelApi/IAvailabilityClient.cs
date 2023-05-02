using HotelsHub.API.Domain.Models.HotelbedsModel.auto.messages.requests.availability;
using HotelsHub.API.Domain.Models.HotelbedsModel.auto.messages.responses.availability;

namespace HotelsHub.API.Application.Abstractions.ExternalCalls.Hotelbeds.HotelApi
{
    public interface IAvailabilityClient
    {
        Task<AvailabilityRS> GetAvailability(AvailabilityRQ availabilityRQ);
    }
}
