using System;
using System.Collections.Generic;
using HotelsHub.API.Domain.Models.HotelbedsModel.auto.model;

namespace HotelsHub.API.Domain.Models.HotelbedsModel.auto.messages.responses.checkrate
{
    public class CheckRateRS : AbstractGenericResponse
    {
        public List<string> providerDetails { get; set; }
        public Hotel hotel { get; set; }
        public Source source { get; set; }
    }
}
