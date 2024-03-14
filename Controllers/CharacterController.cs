using Dotnet_Rpg_Project.DTO.Character;
using Dotnet_Rpg_Project.Models;
using Dotnet_Rpg_Project.Services.CharacterService;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_Rpg_Project.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService) {
            _characterService = characterService;
        }
      

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> GetAll()
        {
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> GetSingle(int id)
        {
            var character = await _characterService.GetCharacterById(id);
            if (character is not null)
            {
                return Ok(character);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> AddCharacter(AddCharacterDto newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }
    }
}
