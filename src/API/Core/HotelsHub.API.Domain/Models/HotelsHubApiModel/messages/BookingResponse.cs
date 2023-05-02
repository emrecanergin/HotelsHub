namespace HotelsHub.API.Domain.Models.HotelsHubApiModel.messages
{
    public class BookingResponse
    {
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int HotelCode { get; set; }
        public double TotalProcessTime { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }
        public string Status { get; set; }
        //public Holder Holder { get; set; }
        public bool CommissionPrice { get; set; }
        public string ClientReference { get; set; }
        public string Remarks { get; set; }
    }
}
