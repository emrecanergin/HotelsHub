using HotelsHub.API.Domain.Models.HotelbedsModel.auto.messages.responses.availability;
using HotelsHub.API.Domain.Models.HotelMappingModel.Models;

namespace HotelsHub.API.Application.Abstractions.HotelMapping
{
    public interface IResponseMap
    {
        public MappedBody Mapping(AvailabilityRS body);
    }
}
