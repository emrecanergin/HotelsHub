using System.Collections.Generic;

namespace HotelsHub.API.Domain.Models.HotelbedsModel.auto.model
{
    public class RateBreakDown
    {
        public List<RateDiscount> rateDiscounts { get; set; }
        public List<RateSupplement> rateSupplements { get; set; }
    }
}
