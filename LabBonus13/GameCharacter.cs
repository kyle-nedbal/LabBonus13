using System;
namespace LabBonus13
{
    public class GameCharacter
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }

        public GameCharacter(string name, int strength, int intelligence)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
        }
        public virtual void Play()
        {
            Console.WriteLine($"Character: {Name}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Intelligence: {Intelligence}");
        }
    }
}
