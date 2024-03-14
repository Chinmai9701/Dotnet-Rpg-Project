using AutoMapper;
using Dotnet_Rpg_Project.DTO.Character;
using Dotnet_Rpg_Project.Models;

namespace Dotnet_Rpg_Project
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character,GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<UpdateCharacterDto, Character>();
        }
    }
}
