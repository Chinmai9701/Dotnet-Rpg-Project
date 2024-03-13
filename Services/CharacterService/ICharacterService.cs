using Dotnet_Rpg_Project.Models;

namespace Dotnet_Rpg_Project.Services.CharacterService
{
    public interface ICharacterService
    {
        List<Character> GetAllCharacters();
        Character? GetCharacterById(int id);

        List<Character> AddCharacter(Character newCharacter);
    }
}
