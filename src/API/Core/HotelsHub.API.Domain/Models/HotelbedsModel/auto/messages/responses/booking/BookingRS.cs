using System.Collections.Generic;
using HotelsHub.API.Domain.Models.HotelbedsModel.auto.model;

namespace HotelsHub.API.Domain.Models.HotelbedsModel.auto.messages.responses.booking
{
    public class BookingRS : AbstractGenericResponse
    {
        public List<string> providerDetails { get; set; }
        public Booking booking { get; set; }
        public Source source { get; set; }
    }
}
