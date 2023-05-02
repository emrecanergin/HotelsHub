namespace HotelsHub.API.Domain.Models.HotelsHubApiModel.model
{
    public class RequestRoom
    {
        public int RoomIndex { get; set; }
        public IList<Pax>? Paxes { get; set; }
    }
}
