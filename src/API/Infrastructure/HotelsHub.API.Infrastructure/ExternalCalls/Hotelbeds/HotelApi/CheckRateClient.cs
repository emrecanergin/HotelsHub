using HotelsHub.API.Application.Abstractions.ExternalCalls.Hotelbeds.HotelApi;
using HotelsHub.API.Domain.Models.HotelbedsModel.auto.messages.requests.checkrate;
using HotelsHub.API.Domain.Models.HotelbedsModel.auto.messages.responses.checkrate;

namespace HotelsHub.API.Infrastructure.ExternalCalls.Hotelbeds.HotelApi
{
    internal class CheckRateClient : ICheckRateClient
    {
        public Task<CheckRateRS> CheckRate(CheckRateRQ checkRateRQ)
        {
            throw new NotImplementedException();
        }
    }
}
