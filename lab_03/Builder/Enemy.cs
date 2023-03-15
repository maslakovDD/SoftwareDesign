using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Enemy : ACharacter
    {
        public string SetName(string name)
        {
            return this._name = name;
        }
        public int SetDamage(int damage)
        {
            return this._damage = damage;
        }
        public int SetHitPoints(int hitPoints)
        {
            return this._hitPoints = hitPoints;
        }
        public int SetWeapon(int weapon)
        {
            return this._weapon = weapon;
        }
        public int SetArmor(int armor)
        {
            return this._armor = armor;
        }
        public string SetAbility(string ability)
        {
            return this._ability = ability;
        }
    }
}
