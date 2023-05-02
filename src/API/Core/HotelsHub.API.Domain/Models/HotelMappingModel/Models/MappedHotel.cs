namespace HotelsHub.API.Domain.Models.HotelMappingModel.Models
{
    public class MappedHotel
    {
        public HotelFeatures hotelFeatures { get; set; }
        public List<List<Room>> roomGroups { get; set; } = new();
    }
}
