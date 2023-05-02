using AutoMapper;
using HotelsHub.API.Domain.Models.HotelbedsModel.auto.model;
using HotelsHub.API.Domain.Models.HotelMappingModel.Models;
using HotelsHub.API.Domain.Models.HotelsHubApiModel.model;

namespace HotelsHub.API.Application.Automapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Domain.Models.HotelbedsModel.auto.model.Hotel, HotelFeatures>();

            CreateMap<HotelFeatures, Domain.Models.HotelbedsModel.auto.model.Hotel>();

            CreateMap<PaymentCard, Domain.Models.HotelbedsModel.auto.model.CreditCard>();
            CreateMap<Domain.Models.HotelbedsModel.auto.model.CreditCard, PaymentCard>();

            CreateMap<ResponseRoom, Domain.Models.HotelMappingModel.Models.Room>();
            CreateMap<Domain.Models.HotelMappingModel.Models.Room, ResponseRoom>()
                .ForMember(d => d.PaymentType, m => m.MapFrom(s => s.rate.paymentType))
                .ForMember(d => d.BoardMainCode, m => m.MapFrom(s => s.rate.boardCode))
                .ForMember(d => d.BoardMainName, m => m.MapFrom(s => s.rate.boardName))
                .ForMember(d => d.RoomIndex, m => m.MapFrom(s => s.rate.rooms))
                .ForMember(d => d.Price, m => m.MapFrom(s => s.rate.net))
                .ForMember(d => d.RoomCode, m => Guid.NewGuid().ToString())
                .ForMember(d => d.RoomName, m => m.MapFrom(s => s.roomname));
        }
    }
}
