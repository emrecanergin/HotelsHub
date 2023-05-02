using HotelsHub.API.Application.Abstractions.ExternalCalls.Hotelbeds.HotelApi;
using HotelsHub.API.Domain.Models.HotelbedsModel.auto.messages.requests.booking;
using HotelsHub.API.Domain.Models.HotelbedsModel.auto.messages.responses.booking;

namespace HotelsHub.API.Infrastructure.ExternalCalls.Hotelbeds.HotelApi
{
    internal class BookingClient : IBookingClient
    {
        public void BookingCancellation()
        {
            throw new NotImplementedException();
        }

        public void BookingChange()
        {
            throw new NotImplementedException();
        }

        public Task<BookingConfirmationRS> BookingConfirmation(BookingConfirmationRQ bookingConfirmationRQ)
        {
            throw new NotImplementedException();
        }

        public Task<BookingDetailRS> BookingDetail(BookingDetailRQ bookingDetailRQ)
        {
            throw new NotImplementedException();
        }

        public Task<BookingListRS> BookingList(BookingListRQ bookingListRQ)
        {
            throw new NotImplementedException();
        }

        public void BookingReconfirmation()
        {
            throw new NotImplementedException();
        }
    }
}
