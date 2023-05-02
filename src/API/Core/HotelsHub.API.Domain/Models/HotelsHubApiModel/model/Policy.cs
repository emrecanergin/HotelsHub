namespace HotelsHub.API.Domain.Models.HotelsHubApiModel.model
{
    public class Policy
    {
        public decimal Price { get; set; }
        public MinimumSalePrice MinimumSalePrice { get; set; }
        public string Currency { get; set; }
        public string Startdate { get; set; }
        public string Enddate { get; set; }
        public byte PolicyType { get; set; }
    }
}
