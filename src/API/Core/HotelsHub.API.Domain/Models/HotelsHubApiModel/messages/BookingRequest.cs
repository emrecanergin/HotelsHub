using HotelsHub.API.Domain.Models.HotelsHubApiModel.model;

namespace HotelsHub.API.Domain.Models.HotelsHubApiModel.messages
{
    public class BookingRequest
    {
        public Holder holder { get; set; }
        public List<BookingRequestRoom> rooms { get; set; }
        public CreditCard creditCard { get; set; }
        public string valuationToken { get; set; }
        public string clientReference { get; set; }
        public string remark { get; set; }
    }
}
