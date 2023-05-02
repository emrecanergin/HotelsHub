using Newtonsoft.Json;
using HotelsHub.API.Domain.Models.HotelbedsModel.auto.common;
using HotelsHub.API.Domain.Models.HotelbedsModel.util;

namespace HotelsHub.API.Domain.Models.HotelbedsModel.auto.model
{
    public class Rate : BasicRate
    {
        public string rateName { get; set; }
        public string rateCommentsId { get; set; }
        public string rateComments { get; set; }
        [JsonProperty("paymentType", Required = Required.Always)]
        [JsonConverter(typeof(JSonConverters.PaymentTypeConverter))]
        public SimpleTypes.PaymentType paymentType { get; set; }
        public bool packaging { get; set; }
        public string boardCode { get; set; }
        public string boardName { get; set; }
        public List<CancellationPolicy> cancellationPolicies { get; set; }
        public Taxes taxes { get; set; }
        public RateBreakDown rateBreakDown { get; set; }
        public int rooms { get; set; }
        public int adults { get; set; }
        public int children { get; set; }
        public string childrenAges { get; set; }
        public List<Promotion> promotions { get; set; }
        public List<Offer> offers { get; set; }
        public List<ShiftRate> shiftRates { get; set; }
        public decimal rateup { get; set; }
    }
}
