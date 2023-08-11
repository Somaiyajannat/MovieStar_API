global using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace MovieStar.Services;


public class CharacterService : ICharacterService
{
   
    private static List<Character> characterList = new List<Character> {
        new Character(),
        new Character{
            Id = 1
        }
    } ;
    private readonly IMapper _mapper;
    public CharacterService(IMapper mapper){
        _mapper = mapper;
    }
    // get single charcater
    public async Task<ServiceResponse<Character>> getSingleCharacter(int id){
        var serviceResponse = new ServiceResponse<Character>();
        var data = characterList.Where(x => x.Id == id).FirstOrDefault();
        serviceResponse.Data = data;
        return serviceResponse;

    }
    // get all character

    public async Task<ServiceResponse<List<Character>>> getAllCharacter() {
        var serviceResponse = new ServiceResponse<List<Character>>();
        serviceResponse.Data = characterList;
        return serviceResponse;
   }

    public async Task<ServiceResponse<List<Character>>> addCharacter(Character NewCharacter){
        var serviceResponse = new ServiceResponse<List<Character>>();
        characterList.Add(NewCharacter);
        serviceResponse.Data = characterList;
        return serviceResponse;
    }

    
}
