using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    internal class EnemyBuilder : ICharacterBuilder
    {
        private Enemy _enemy = new();

        public ICharacterBuilder BuildAbility(string ability)
        {
            this._enemy.SetAbility(ability);
            return this;
        }

        public ICharacterBuilder BuildArmor(int armor)
        {
            this._enemy.SetArmor(armor);
            return this;
        }

        public ICharacterBuilder BuildDamage(int damage)
        {
            this._enemy.SetDamage(damage);
            return this;
        }

        public ICharacterBuilder BuildHitPoints(int hitPoints)
        {
            this._enemy.SetHitPoints(hitPoints);
            return this;
        }

        public ICharacterBuilder BuildName(string name)
        {
            this._enemy.SetName(name);
            return this;
        }

        public ICharacterBuilder BuildWeapon(int weapon)
        {
            this._enemy.SetWeapon(weapon);
            return this;
        }

        public ACharacter GetCharacter()
        {
            Enemy enemy = this._enemy;
            this._reset();
            return enemy;
        }

        private void _reset()
        {
            this._enemy = new();
        }
    }
}
