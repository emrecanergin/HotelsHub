using HotelsHub.API.Domain.Models.HotelbedsModel.auto.messages.requests.checkrate;
using HotelsHub.API.Domain.Models.HotelbedsModel.auto.messages.responses.checkrate;

namespace HotelsHub.API.Application.Abstractions.ExternalCalls.Hotelbeds.HotelApi
{
    public interface ICheckRateClient
    {
        Task<CheckRateRS> CheckRate(CheckRateRQ checkRateRQ);
    }
}
