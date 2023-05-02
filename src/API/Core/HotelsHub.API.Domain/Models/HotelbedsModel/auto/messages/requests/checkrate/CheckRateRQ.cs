using System;
using System.Collections.Generic;
using HotelsHub.API.Domain.Models.HotelbedsModel.auto.model;

namespace HotelsHub.API.Domain.Models.HotelbedsModel.auto.messages.requests.checkrate
{
    public class CheckRateRQ : AbstractGenericRequest
    {
        public bool upselling { get; set; }
        public List<BookingRoom> rooms { get; set; }

        public void Validate()
        {
            if (rooms == null)
                throw new ArgumentException("Rooms list can't be null");

            for (int r = 0; r < rooms.Count; r++)
            {
                if (string.IsNullOrEmpty(rooms[r].rateKey))
                    throw new ArgumentException("RateKey Room can't be null or empty");
            }
        }
    }
}
