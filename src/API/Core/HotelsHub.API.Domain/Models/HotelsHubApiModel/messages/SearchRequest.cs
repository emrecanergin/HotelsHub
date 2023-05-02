using HotelsHub.API.Domain.Models.HotelsHubApiModel.model;

namespace HotelsHub.API.Domain.Models.HotelsHubApiModel.messages
{
    public class SearchRequest
    {
        public Authentication Authentication { get; set; }
        public string CheckIn { get; set; }
        public string CheckOut { get; set; }
        public string? Language { get; set; }
        public string? Nationality { get; set; }
        public MultiRoomGroup? MultiRoomGroup { get; set; }
        public Filter? Filter { get; set; }
        public Setting? Settings { get; set; }
        public Info? Info { get; set; }
    }
}
