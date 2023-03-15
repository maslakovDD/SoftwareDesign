using Builder.Builders;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CharacterDirector director = new(new HeroBuilder());
            ACharacter character = director.MakeWizardCharacter();
            director.SetBuilder(new EnemyBuilder());
            character = director.MakeAssassinCharacter();
        }
    }
}