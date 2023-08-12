using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieStar.Dto;

namespace MovieStar.Services;

public interface ICharacterService
{
    Task <ServiceResponse<CharacterDto>> getSingleCharacter(int id);
    Task <ServiceResponse<List<CharacterDto>>> getAllCharacter();
    Task <ServiceResponse<List<CharacterDto>>> addCharacter(CharacterDto NewCharacter);

}
