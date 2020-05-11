using System;
namespace LabBonus13
{
    public class Warrior : GameCharacter 
    {
        public string WeaponType { get; set; }

        public Warrior(string name, int strength, int intelligence, string weaponType)
            : base(name, strength, intelligence)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            WeaponType = weaponType;
        }

        public override void Play()
        {
            Console.WriteLine($"Character: {Name}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Intelligence: {Intelligence}");
            Console.WriteLine($"Weapon Type: {WeaponType}");
        }
    }
}
