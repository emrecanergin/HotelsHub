using HotelsHub.API.Domain.Models.HotelsHubApiModel.model;

namespace HotelsHub.API.Domain.Models.HotelsHubApiModel.messages
{
    public class SearchResponse
    {
        public int SearchId { get; set; }
        public IList<Hotel> Hotels { get; set; }
        public double SupplierCommunicationTime { get; set; }
    }
}
