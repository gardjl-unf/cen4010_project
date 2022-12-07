using AutoMapper;
using OpenBed.Models;
using OpenBed.Models.ViewModels;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Shelter, ShelterViewModel>();
        CreateMap<ShelterViewModel, Shelter>();
        CreateMap<Room, RoomViewModel>();
        CreateMap<RoomViewModel, Room>();
    }
}