﻿using Dotnet_Rpg_Project.Models;

namespace Dotnet_Rpg_Project.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<List<Character>> GetAllCharacters();
        Task<Character?> GetCharacterById(int id);

        Task<List<Character>> AddCharacter(Character newCharacter);
    }
}