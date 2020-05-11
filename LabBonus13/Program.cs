using System;

namespace LabBonus13
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameCharacter = new GameCharacter[5];
            gameCharacter[0] = new Warrior("Hector", 85, 35, "Dagger");
            gameCharacter[1] = new Warrior("Thor", 90, 45, "Hammer");
            gameCharacter[2] = new Wizard("Abra", 35, 85, 52, 80);
            gameCharacter[3] = new Wizard("Kadabra", 35, 90, 12, 75);
            gameCharacter[4] = new Wizard("Alakazam", 50, 80, 97, 95);

            foreach (var character in gameCharacter)
            {
                character.Play();
                Console.WriteLine();
            }
        }
    }
}
