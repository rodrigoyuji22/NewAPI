using AutoMapper;
using NewAPI.Dtos;
using NewAPI.Entities;

namespace NewAPI.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<CreateUserDto, User>();
    }
}