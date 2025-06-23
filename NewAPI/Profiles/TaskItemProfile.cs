using AutoMapper;
using NewAPI.Dtos;
using NewAPI.Entities;

namespace NewAPI.Profiles;

public class TaskItemProfile : Profile
{
    public TaskItemProfile()
    {
        CreateMap<CreateTaskItemDto, TaskItem>();
        CreateMap<TaskItem, ReadTaskItemDto>();
        CreateMap<UpdateTaskItemDto, TaskItem>();
    }
}