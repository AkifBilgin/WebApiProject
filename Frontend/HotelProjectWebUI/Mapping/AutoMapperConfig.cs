using AutoMapper;
using AutoMapper.Configuration;
using HotelProjectEntityLayer.Concrete;
using HotelProjectWebUI.Dtos.AboutUsDto;
using HotelProjectWebUI.Dtos.BookingDto;
using HotelProjectWebUI.Dtos.LoginDto;
using HotelProjectWebUI.Dtos.RegisterDto;
using HotelProjectWebUI.Dtos.ServiceDto;
using HotelProjectWebUI.Dtos.StaffDto;
using HotelProjectWebUI.Dtos.SubscribeDto;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Query;

namespace HotelProjectWebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();

            CreateMap<ResultAboutUsDto, AboutUs>().ReverseMap();
            CreateMap<UpdateAboutDto, AboutUs>().ReverseMap();


            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();

            CreateMap<ResultStaffDto, Staff>().ReverseMap();    

            CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();


            CreateMap<CreateBookingDto, Booking>().ReverseMap();
            CreateMap<ConfirmReservationDto, Booking>().ReverseMap();

        }
    }
}
