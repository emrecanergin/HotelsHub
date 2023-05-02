using System.Collections.Generic;

namespace HotelsHub.API.Domain.Models.HotelbedsModel.auto.model
{
    public class KeywordsFilter
    {
        public List<int> keyword { get; set; }
        public bool allIncluded { get; set; }

        public KeywordsFilter(List<int> keywords, bool allIncluded)
        {
            keyword = keywords;
            this.allIncluded = allIncluded;
        }
    }
}
