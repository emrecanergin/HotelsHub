using System.Collections.Generic;

namespace HotelsHub.API.Domain.Models.HotelbedsModel.auto.model
{
    public class BookingRoom
    {
        public string rateKey { get; set; }
        public List<Pax> paxes;
    }
}
