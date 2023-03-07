using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab_02.Interfaces;

namespace lab_02.Classes.Currency
{
    public abstract class Money : ICurrency
    {
        public int Cash { get; set; }
        public int Coins { get; set; }
        public string Name { get; protected set; }
        public double DollarCoefficient { get;protected set; }
        public Money(int cash, int coins)
        {
            _setName();
            _setDollarCoefficient();
            Cash = cash;
            Coins = coins;
        }
        public Money(ICurrency money)
        {
            Cash = money.Cash;
            Coins = money.Coins;
            Name = money.Name;
        }
        protected abstract void _setDollarCoefficient();
        protected abstract void _setName();
        public override string ToString()
        {
            return $"{Cash}.{Coins} {Name}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            else
            {
                if (obj is Money)
                {
                    var item = obj as Money;
                    return item.Cash == Cash && item.Coins == Coins && item.Name.Equals(Name);
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
