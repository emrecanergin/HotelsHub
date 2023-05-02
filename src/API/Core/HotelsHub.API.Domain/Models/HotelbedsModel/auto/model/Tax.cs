using HotelsHub.API.Domain.Models.HotelbedsModel.auto.common;
using HotelsHub.API.Domain.Models.HotelbedsModel.util;
using Newtonsoft.Json;

namespace HotelsHub.API.Domain.Models.HotelbedsModel.auto.model
{
    public class Tax
    {
        public bool included { get; set; }
        public decimal percent { get; set; }
        public decimal amount { get; set; }
        public string currency { get; set; }
        [JsonConverter(typeof(JSonConverters.TaxTypeConverter))]
        public SimpleTypes.TaxType type { get; set; }
        public decimal clientAmount { get; set; }
        public string clientCurrency { get; set; }
    }
}
