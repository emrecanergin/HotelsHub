using HotelsHub.API.Domain.Models.HotelbedsModel.auto.common;
using HotelsHub.API.Domain.Models.HotelbedsModel.util;
using Newtonsoft.Json;

namespace HotelsHub.API.Domain.Models.HotelbedsModel.auto.model
{
    public class ReviewFilter
    {
        [JsonProperty("type", Required = Required.Always)]
        [JsonConverter(typeof(JSonConverters.AccommodationTypeConverter))]
        public SimpleTypes.ReviewsType? type { get; set; }
        public decimal minRate { get; set; }
        public decimal maxRate { get; set; }
        public int minReviewCount { get; set; }
    }
}
