using HotelsHub.API.Domain.Models.HotelbedsModel.auto.common;

namespace HotelsHub.API.Domain.Models.HotelbedsModel.auto.model
{
    public class Room
    {
        public SimpleTypes.BookingStatus status;
        public string code { get; set; }
        public string name { get; set; }
        public List<Pax> paxes { get; set; }
        public List<Rate> rates { get; set; }
    }
}