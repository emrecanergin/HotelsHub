using HotelsHub.API.Domain.Models.HotelsHubApiModel.model;

namespace HotelsHub.API.Domain.Models.HotelsHubApiModel.messages
{
    public class CheckResponse
    {
        public Hotel hotel { get; set; }
        public IList<RoomCRS> rooms { get; set; }
        public string ValuationId { get; set; }
        public decimal Price { get; set; }
        public double MinimumSellingPrice { get; set; }
        public bool CommissionPrice { get; set; }
        public bool Promotion { get; set; }
        public string Currency { get; set; }
        public IList<Policy> Policies { get; set; }
        public IList<PolicyRemark> PolicyRemarks { get; set; }
        public IList<TaxesAndFee> TaxesAndFees { get; set; }
        public string Remark { get; set; }
        public bool OnRequest { get; set; }
    }
}
