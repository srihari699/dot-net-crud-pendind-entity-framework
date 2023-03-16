namespace Dotnet_Demo
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
