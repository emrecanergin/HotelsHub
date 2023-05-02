using HotelsHub.API.Domain.Models.HotelbedsModel.auto.model;

namespace HotelsHub.API.Domain.Models.HotelbedsModel.auto.messages.responses.booking
{
    public class BookingDetailRS : AbstractGenericResponse
    {
        public Booking booking { get; set; }
    }
}
