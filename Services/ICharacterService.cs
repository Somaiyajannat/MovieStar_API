using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace MovieStar.Services;

public interface ICharacterService
{
    Task <ServiceResponse<Character>> getSingleCharacter(int id);
    Task <ServiceResponse<List<Character>>> getAllCharacter();
    Task <ServiceResponse<List<Character>>> addCharacter(Character NewCharacter);

}
