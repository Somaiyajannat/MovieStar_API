using MovieStar.Dto;

namespace MovieStar;

public class AutoMapperProfile : Profile{
    public AutoMapperProfile(){
        CreateMap<Character, CharacterDto>();
        CreateMap<CharacterDto, Character>();
    }
}