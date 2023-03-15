using Builder.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class CharacterDirector
    {
        private ICharacterBuilder _characterBuilder;
        public CharacterDirector(ICharacterBuilder characterBuilder)
        {
            this._characterBuilder = characterBuilder;
        }
        public ICharacterBuilder SetBuilder(ICharacterBuilder characterBuilder)
        {
            return this._characterBuilder = characterBuilder;
        }
        public ACharacter MakeWizardCharacter()
        {
           return _characterBuilder
                .BuildName("Vilgefortz")
                .BuildHitPoints(50)
                .BuildDamage(100)
                .BuildArmor(10)
                .BuildWeapon(150)
                .BuildAbility("Super power magic")
                .GetCharacter();
        }

        public ACharacter MakeAssassinCharacter()
        {
            return _characterBuilder
                .BuildName("Leto")
                .BuildHitPoints(75)
                .BuildDamage(50)
                .BuildArmor(50)
                .BuildWeapon(250)
                .BuildAbility("Stealth")
                .GetCharacter();
        }
        public ACharacter MakeSoldierCharacter()
        {
            return _characterBuilder
                .BuildName("Reiner")
                .BuildHitPoints(100)
                .BuildDamage(50)
                .BuildArmor(100)
                .BuildWeapon(50)
                .BuildAbility("Strength")
                .GetCharacter();
        }
    }
}
