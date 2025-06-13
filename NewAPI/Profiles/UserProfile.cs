using AutoMapper;
using NewAPI.Dtos;
using NewAPI.Entities;

namespace NewAPI.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<CreateUserDto, User>().ForMember(destiny => destiny.UserName, opt => opt.MapFrom(src => src.UserName));
    }
}