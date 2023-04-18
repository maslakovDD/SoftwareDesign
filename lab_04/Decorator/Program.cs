using Decorator.Characters;
using Decorator.Decorators;
namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character character = new Palladin();
            character = new ArtefactInventory(character, "magic sword");
            character = new WeaponInventory(character, 20);
            character.ShowStats();

            character = new Mage();
            character = new WeaponInventory(character, 50);

            character.ShowStats();

        }
    }
}