using HotelsHub.API.Application.Abstractions.ExternalCalls.Hotelbeds.RequestBodyGenerators;
using HotelsHub.API.Domain.Models.HotelbedsModel.auto.common;
using HotelsHub.API.Domain.Models.HotelbedsModel.auto.messages.requests.availability;
using HotelsHub.API.Domain.Models.HotelbedsModel.auto.model;
using HotelsHub.API.Domain.Models.HotelsHubApiModel.messages;

namespace HotelsHub.API.Infrastructure.ExternalCalls.Hotelbeds.RequestGenerators
{
    public class AvailabilityRequestGenerator : IAvailabilityRequestGenerator
    {
        public AvailabilityRQ CreateAvailabilityRequestBody(SearchRequest searchRequest)
        {
            List<Occupancy> occupancies = new List<Occupancy>();
            List<Pax> paxlist = new();

            foreach (var room in searchRequest.Settings.Rooms)
            {
                foreach (var pax in room.Paxes)
                {
                    paxlist.Add(new Pax
                    {
                        age = pax.PaxAge,
                        type = pax.PaxAge <= 18 ? SimpleTypes.HotelbedsCustomerType.CH : SimpleTypes.HotelbedsCustomerType.AD
                    });
                }

                int childrenCount = paxlist.Count(x => x.age < 18);
                int adultCount = paxlist.Count(x => x.age > 18);

                occupancies.Add(
                    new Occupancy
                    {
                        rooms = room.RoomIndex,
                        adults = adultCount,
                        children = childrenCount,
                        paxes = paxlist
                    });
                paxlist.Clear();
            }

            var destinationCode = searchRequest.Settings.DestinationCode;
            var stay = new Stay { checkIn = searchRequest.CheckIn, checkOut = searchRequest.CheckOut };

            var codes = new HotelsFilter { hotel = (List<int>)searchRequest.Settings.HotelCodes };
            var total = new AvailabilityRQ
            {
                stay = stay,
                occupancies = occupancies,
                hotels = searchRequest.Settings.HotelCodes != null ? codes : null,
                destination = destinationCode != null ? new Destination { code = destinationCode.Code } : null,              
            };
            return total;
        }
    }
}
