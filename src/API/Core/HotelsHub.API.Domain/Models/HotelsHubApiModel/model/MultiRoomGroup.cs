namespace HotelsHub.API.Domain.Models.HotelsHubApiModel.model
{
    public class MultiRoomGroup
    {
        public bool GroupRooms { get; set; }
        public bool SameRefundableNonRefundable { get; set; }
        public bool SameBoardMain { get; set; }
        public bool SameBoardSub { get; set; }
    }
}
