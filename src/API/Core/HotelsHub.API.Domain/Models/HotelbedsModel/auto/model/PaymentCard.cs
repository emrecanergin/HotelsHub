﻿namespace HotelsHub.API.Domain.Models.HotelbedsModel.auto.model
{
    public class PaymentCard
    {
        public string cardType { get; set; }
        public string cardNumber { get; set; }
        public string cardHolderName { get; set; }
        public string expiryDate { get; set; }
        public string cardCVC { get; set; }
    }
}
