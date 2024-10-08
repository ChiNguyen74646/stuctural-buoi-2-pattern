using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.NetOptimized
{
    public class CharacterFactory
    {
        private readonly Dictionary<char, Character> characters = [];
        public Character GetCharacter(char key)
        {
            // Uses "lazy initialization"
            Character character;
            if (characters.TryGetValue(key, out Character? value))
            {
                character = value;
            }
            else
            {
                switch (key)
                {
                    case 'A': character = new CharacterA(); break;
                    case 'B': character = new CharacterB(); break;
                    //...
                    case 'Z': character = new CharacterZ(); break;
                }
                characters.Add(key, character);
            }
            return character;
        }
    }
}
