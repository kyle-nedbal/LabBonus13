using System;
namespace LabBonus13
{
    public class MagicUsingCharacter : GameCharacter
    {
        public int MagicalEnergy { get; set; }

        public MagicUsingCharacter(string name, int strength, int intelligence, int magicalEnergy)
            : base(name ,strength, intelligence)
        { 
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            MagicalEnergy = magicalEnergy;
        }

        public override void Play()
        {
            Console.WriteLine($"Character: {Name}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Intelligence: {Intelligence}");
            Console.WriteLine($"Magical Energy: {MagicalEnergy}");
        }
    }
}
