// MappingProfile.cs

using AutoMapper;
using EcoMeChan.Models;
using EcoMeChan.ViewModels;
using EcoMeChan.ViewModels.Create;
using EcoMeChan.ViewModels.Edit;
using EcoMeChan.ViewModels.Extended;
using EcoMeChan_Backend.ViewModels;

namespace EcoMeChan.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Consumption, ConsumptionViewModel>().ReverseMap();
            CreateMap<IoTDevice, IoTDeviceViewModel>().ReverseMap();
            CreateMap<Notification, NotificationViewModel>().ReverseMap();
            CreateMap<SensorData, SensorDataViewModel>().ReverseMap();
            CreateMap<Tariff, TariffViewModel>().ReverseMap();
            CreateMap<User, UserViewModel>().ReverseMap();

            CreateMap<ConsumptionCreateViewModel, Consumption>().ReverseMap();
            CreateMap<IoTDeviceCreateViewModel, IoTDevice>().ReverseMap();
            CreateMap<NotificationCreateViewModel, Notification>().ReverseMap();
            CreateMap<SensorDataCreateViewModel, SensorData>().ReverseMap();
            CreateMap<TariffCreateViewModel, Tariff>().ReverseMap();
            CreateMap<UserCreateViewModel, User>().ReverseMap();

            CreateMap<ConsumptionCreateViewModel, ConsumptionViewModel>().ReverseMap();
            CreateMap<IoTDeviceCreateViewModel, IoTDeviceViewModel>().ReverseMap();
            CreateMap<NotificationCreateViewModel, NotificationViewModel>().ReverseMap();
            CreateMap<SensorDataCreateViewModel, SensorDataViewModel>().ReverseMap();
            CreateMap<TariffCreateViewModel, TariffViewModel>().ReverseMap();
            CreateMap<UserCreateViewModel, UserViewModel>().ReverseMap();

            CreateMap<ConsumptionEditViewModel, Consumption>().ReverseMap();
            CreateMap<IoTDeviceEditViewModel, IoTDevice>().ReverseMap();
            CreateMap<NotificationEditViewModel, Notification>().ReverseMap();
            CreateMap<SensorDataEditViewModel, SensorData>().ReverseMap();
            CreateMap<TariffEditViewModel, Tariff>().ReverseMap();
            CreateMap<UserEditViewModel, User>().ReverseMap();

            CreateMap<ConsumptionEditViewModel, ConsumptionViewModel>().ReverseMap();
            CreateMap<IoTDeviceEditViewModel, IoTDeviceViewModel>().ReverseMap();
            CreateMap<NotificationEditViewModel, NotificationViewModel>().ReverseMap();
            CreateMap<SensorDataEditViewModel, SensorDataViewModel>().ReverseMap();
            CreateMap<TariffEditViewModel, TariffViewModel>().ReverseMap();
            CreateMap<UserEditViewModel, UserViewModel>().ReverseMap();

            CreateMap<IoTDevice, IoTDeviceExtendedViewModel>()
                .ForMember(dest => dest.Notifications, opt => opt.MapFrom(src => src.Notifications))
                .ForMember(dest => dest.SensorData, opt => opt.MapFrom(src => src.SensorData));

            CreateMap<User, UserExtendedViewModel>()
                .ForMember(dest => dest.Consumptions, opt => opt.MapFrom(src => src.Consumptions))
                .ForMember(dest => dest.Notifications, opt => opt.MapFrom(src => src.Notifications));
        }
    }
}