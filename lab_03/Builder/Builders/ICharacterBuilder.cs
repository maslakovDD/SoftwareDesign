using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    internal interface ICharacterBuilder
    {
        public ICharacterBuilder BuildName(string name);
        public ICharacterBuilder BuildDamage(int damage);
        public ICharacterBuilder BuildHitPoints(int hitPoints);
        public ICharacterBuilder BuildWeapon(int weapon);
        public ICharacterBuilder BuildArmor(int armor);
        public ICharacterBuilder BuildAbility(string ability);
        public ACharacter GetCharacter();
    }
}
