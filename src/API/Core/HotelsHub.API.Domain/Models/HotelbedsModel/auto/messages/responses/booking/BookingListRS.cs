using HotelsHub.API.Domain.Models.HotelbedsModel.auto.model;

namespace HotelsHub.API.Domain.Models.HotelbedsModel.auto.messages.responses.booking
{
    public class BookingListRS : AbstractGenericResponse
    {
        public Bookings bookings { get; set; }
    }
}
