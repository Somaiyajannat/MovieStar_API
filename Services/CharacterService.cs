global using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieStar.Dto;

namespace MovieStar.Services;


public class CharacterService : ICharacterService
{
   
    private static List<Character> characterList = new List<Character> {
        new Character{
            Id = 1
        },
        new Character{
            Id = 2
        }
    } ;
    private readonly IMapper _mapper;
    public CharacterService(IMapper mapper){
        _mapper = mapper;
    }
    // get single charcater
    public async Task<ServiceResponse<CharacterDto>> getSingleCharacter(int id){
        var serviceResponse = new ServiceResponse<CharacterDto>();
        var data = characterList.Where(x => x.Id == id).FirstOrDefault();
        serviceResponse.Data = _mapper.Map<CharacterDto>(characterList);
        return serviceResponse;

    }
    // get all character

    public async Task<ServiceResponse<List<CharacterDto>>> getAllCharacter() {

        var serviceResponse = new ServiceResponse<List<CharacterDto>>();
        serviceResponse.Data = characterList.Select(c => _mapper.Map<CharacterDto>(c)).ToList();
        return serviceResponse;
   }
 // add charcater
    public async Task<ServiceResponse<List<CharacterDto>>> addCharacter(CharacterDto NewCharacter){
        var serviceResponse = new ServiceResponse<List<CharacterDto>>();
        var character = _mapper.Map<Character>(NewCharacter);
        character.Id = characterList.Max(c => c.Id) + 1;
        characterList.Add(_mapper.Map<Character>(NewCharacter));
        serviceResponse.Data = characterList.Select(c =>_mapper.Map<CharacterDto>(c)).ToList();
        return serviceResponse;
    }

    
}
