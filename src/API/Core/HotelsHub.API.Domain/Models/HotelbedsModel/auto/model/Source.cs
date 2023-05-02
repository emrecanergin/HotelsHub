using System;
using HotelsHub.API.Domain.Models.HotelbedsModel.auto.common;
using HotelsHub.API.Domain.Models.HotelbedsModel.util;
using Newtonsoft.Json;

namespace HotelsHub.API.Domain.Models.HotelbedsModel.auto.model
{
    public class Source
    {
        [JsonProperty("channel", Required = Required.Always)]
        [JsonConverter(typeof(JSonConverters.ChannelTypeConverter))]
        public SimpleTypes.ChannelType? channel { get; set; }
        [JsonProperty("device", Required = Required.Always)]
        [JsonConverter(typeof(JSonConverters.DeviceTypeConverter))]
        public SimpleTypes.DeviceType? device { get; set; }
        public string deviceInfo { get; set; }

    }
}
