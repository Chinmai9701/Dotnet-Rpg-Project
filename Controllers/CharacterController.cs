using Dotnet_Rpg_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_Rpg_Project.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character> 
        {
            new Character(),
            new Character {Id = 2, Name = "Sam"}
        };

        [HttpGet("GetAll")]
        public ActionResult<List<Character>> Get()
        {
            return Ok(characters);
        }

        [HttpGet("{id}")]
        public ActionResult<Character> GetSingle(int id)
        {
            var character = characters.FirstOrDefault(c => c.Id == id);
            if (character is not null)
            {
                return Ok(character);
            }
            return NotFound();
        }
    }
}
