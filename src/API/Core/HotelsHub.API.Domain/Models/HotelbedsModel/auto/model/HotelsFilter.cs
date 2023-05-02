using HotelsHub.API.Domain.Models.HotelbedsModel.auto.common;
using HotelsHub.API.Domain.Models.HotelbedsModel.util;
using Newtonsoft.Json;

namespace HotelsHub.API.Domain.Models.HotelbedsModel.auto.model
{
    public class HotelsFilter
    {
        public List<int> hotel { get; set; }
        //[JsonProperty("included", Required = Required.Always)]
        //[JsonConverter(typeof(JSonConverters.BooleanConverter))]
        //public bool included { get; set; }
        //[JsonProperty("type", Required = Required.Always)]
        //[JsonConverter(typeof(JSonConverters.HotelCodeTypeConverter))]
        //public SimpleTypes.HotelCodeType? type { get; set; }
    }
}
