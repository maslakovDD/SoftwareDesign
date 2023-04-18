using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Characters
{
    internal abstract class Character
    {
        public int Damage { get; set; } = 10;
        public string Armor { get;set; } = "simple clothes";
        public string ArtefactsPower { get; set; } = "none";

        public Character()
        {
        }
        public Character(Character character)
        {
            this.ArtefactsPower = character.ArtefactsPower;
            this.Armor = character.Armor;
            this.Damage = character.Damage;
        }
        public virtual void ShowStats()
        {
            Console.WriteLine("Chracter stats: ");
            Console.WriteLine($"Damage: {this.Damage}");
            Console.WriteLine($"Armor: {this.Armor}");
            Console.WriteLine($"Artefacts Power: {this.ArtefactsPower}\n");
        }
    } 
}
