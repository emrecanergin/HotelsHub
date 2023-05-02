﻿using HotelsHub.API.Domain.Models.HotelbedsModel.auto.common;

namespace HotelsHub.API.Domain.Models.HotelsHubApiModel.model
{
    public class HotelFilter
    {
        public bool Name { get; set; }
        public bool Address { get; set; }
        public bool Category { get; set; }
        public bool Type { get; set; }
        public decimal MaxPrice { get; set; }
        public decimal MinPrice { get; set; }
        public int MaxHotels { get; set; }

        //[JsonConverter(typeof(JSonConverters.ShowDirectPaymentTypeConverter))]
        public SimpleTypes.ShowDirectPaymentType? PaymentType { get; set; }
        public bool HotelImportantNote { get; set; }
    }
}
