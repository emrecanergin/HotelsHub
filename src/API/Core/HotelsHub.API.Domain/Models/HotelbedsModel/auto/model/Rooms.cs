using HotelsHub.API.Domain.Models.HotelbedsModel.util;
using Newtonsoft.Json;


namespace HotelsHub.API.Domain.Models.HotelbedsModel.auto.model
{
    public class Rooms
    {
        public List<string> room { get; set; }
        [JsonProperty("included", Required = Required.Always)]
        [JsonConverter(typeof(JSonConverters.BooleanConverter))]
        public bool? included { get; set; }
    }
}
