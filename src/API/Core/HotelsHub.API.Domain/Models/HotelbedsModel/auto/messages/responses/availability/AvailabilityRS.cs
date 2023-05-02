using System.Collections.Generic;
using HotelsHub.API.Domain.Models.HotelbedsModel.auto.model;

namespace HotelsHub.API.Domain.Models.HotelbedsModel.auto.messages.responses.availability
{
    public class AvailabilityRS : AbstractGenericResponse
    {
        public List<string> providerDetails { get; set; }
        public Hotels hotels;
        public Source source;
    }
}
