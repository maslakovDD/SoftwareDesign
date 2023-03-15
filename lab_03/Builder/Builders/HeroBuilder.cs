using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    internal class HeroBuilder : ICharacterBuilder
    {
        private Hero _hero = new();

        public ICharacterBuilder BuildAbility(string ability)
        {
            this._hero.SetAbility(ability);
            return this;
        }

        public ICharacterBuilder BuildArmor(int armor)
        {
            this._hero.SetArmor(armor);
            return this;
        }

        public ICharacterBuilder BuildDamage(int damage)
        {
            this._hero.SetDamage(damage);
            return this;
        }

        public ICharacterBuilder BuildHitPoints(int hitPoints)
        {
            this._hero.SetHitPoints(hitPoints);
            return this;
        }

        public ICharacterBuilder BuildName(string name)
        {
            this._hero.SetName(name);
            return this;
        }

        public ICharacterBuilder BuildWeapon(int weapon)
        {
            this._hero.SetWeapon(weapon);
            return this;
        }

        public ACharacter GetCharacter()
        {
            Hero hero = this._hero;
            this._reset();
            return hero;
        }

        private void _reset()
        {
            this._hero = new();
        }

        
    }
}
