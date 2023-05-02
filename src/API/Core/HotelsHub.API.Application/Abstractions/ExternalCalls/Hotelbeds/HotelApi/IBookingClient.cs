using HotelsHub.API.Domain.Models.HotelbedsModel.auto.messages.requests.booking;
using HotelsHub.API.Domain.Models.HotelbedsModel.auto.messages.responses.booking;

namespace HotelsHub.API.Application.Abstractions.ExternalCalls.Hotelbeds.HotelApi
{
    public interface IBookingClient
    {
        Task<BookingListRS> BookingList(BookingListRQ bookingListRQ);
        Task<BookingDetailRS> BookingDetail(BookingDetailRQ bookingDetailRQ);
        Task<BookingConfirmationRS> BookingConfirmation(BookingConfirmationRQ bookingConfirmationRQ);
        void BookingChange();
        void BookingCancellation();
        void BookingReconfirmation();

    }
}
