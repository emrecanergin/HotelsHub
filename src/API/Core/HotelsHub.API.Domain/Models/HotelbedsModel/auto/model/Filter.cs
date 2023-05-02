using HotelsHub.API.Domain.Models.HotelbedsModel.auto.common;
using Newtonsoft.Json;

namespace HotelsHub.API.Domain.Models.HotelbedsModel.auto.model
{
    public class Filter
    {
        public int maxHotels { get; set; }
        public int maxRooms { get; set; }
        public decimal minRate { get; set; }
        public decimal maxRate { get; set; }
        public int maxRatesPerRoom { get; set; }
        public bool packaging { get; set; }

        [JsonProperty("paymentType", Required = Required.Always)]
        public SimpleTypes.ShowDirectPaymentType? paymentType { get; set; }

        [JsonProperty("hotelPackage", Required = Required.Always)]
        public SimpleTypes.HotelPackage? hotelPackage { get; set; }
        public int minCategory { get; set; }
        public int maxCategory { get; set; }
    }
}
