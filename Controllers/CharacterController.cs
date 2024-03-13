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
        public ActionResult<List<Character>> GetAll()
        {
            return Ok(_characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public ActionResult<Character> GetSingle(int id)
        {
            var character = _characterService.GetCharacterById(id);
            if (character is not null)
            {
                return Ok(character);
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<List<Character>> AddCharacter(Character newCharacter)
        {
            return Ok(_characterService.AddCharacter(newCharacter));
        }
    }
}
