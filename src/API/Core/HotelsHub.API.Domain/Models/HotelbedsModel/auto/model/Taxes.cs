using System.Collections.Generic;

namespace HotelsHub.API.Domain.Models.HotelbedsModel.auto.model
{
    public class Taxes
    {
        public List<Tax> taxes { get; set; }
        public bool allIncluded { get; set; }
    }
}
