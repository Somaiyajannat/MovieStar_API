using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieStar.Dto;

namespace MovieStar.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CharacterController : ControllerBase
{
    private readonly  ICharacterService _characterService;
    public  CharacterController(ICharacterService characterService){

        _characterService = characterService;
    }
   
    // get single character
    [HttpGet]
    [Route("~/api/getSingleCharacter/{id}")]
    public  async Task<ActionResult<ServiceResponse<CharacterDto>>> getSingleCharacter(int id){
        return Ok(await _characterService.getSingleCharacter(id));
    }
    // get all character

    [HttpGet]
    [Route("~/api/getAllCharacter")]

    public async Task<ActionResult<ServiceResponse<List<CharacterDto>>>> getAllCharacter(){
        return Ok(await _characterService.getAllCharacter());
    }

    // add a character

    [HttpPost]
    [Route("~/api/addCharacter")]

    public async Task<ActionResult<ServiceResponse<List<CharacterDto>>>> addCharacter(CharacterDto NewCharacter){
        return Ok(await _characterService.addCharacter(NewCharacter));
    }

    

    
}
