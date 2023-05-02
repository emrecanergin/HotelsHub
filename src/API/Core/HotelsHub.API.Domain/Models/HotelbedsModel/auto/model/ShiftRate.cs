using System;

namespace HotelsHub.API.Domain.Models.HotelbedsModel.auto.model
{
    public class ShiftRate : BasicRate
    {
        public DateTime checkIn { get; set; }
        public DateTime checkOut { get; set; }
    }
}
