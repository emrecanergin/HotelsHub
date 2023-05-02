using System.Collections.Generic;

namespace HotelsHub.API.Domain.Models.HotelbedsModel.auto.model
{
    public class Bookings
    {
        public List<Booking> bookings { get; set; }
        public int from { get; set; }
        public int to { get; set; }
        public decimal total { get; set; }
    }
}
