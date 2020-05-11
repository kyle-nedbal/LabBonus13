using System;
namespace LabBonus13
{
    public class Wizard : MagicUsingCharacter
    {
        public int SpellNumber { get; set; }

        public Wizard(string name, int strength, int intelligence, int spellNumber, int magicalEnergy)
            : base(name, strength, intelligence, magicalEnergy)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            SpellNumber = spellNumber;
            MagicalEnergy = magicalEnergy;
        }
        public override void Play()
        {
            Console.WriteLine($"Character: {Name}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Intelligence: {Intelligence}");
            Console.WriteLine($"Magical Energy: {MagicalEnergy}");
            Console.WriteLine($"Spell Number: {SpellNumber}");

        }
    }
}
