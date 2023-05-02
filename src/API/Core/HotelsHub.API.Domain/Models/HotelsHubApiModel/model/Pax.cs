namespace HotelsHub.API.Domain.Models.HotelsHubApiModel.model
{
    public class Pax
    {
        public int PaxOrder { get; set; }
        public int PaxAge { get; set; }
        public string? PaxName { get; set; }
        public string? PaxSurname { get; set; }
        public bool IsLeader { get; set; }
        public string? PaxPrefix { get; set; }
    }
}
