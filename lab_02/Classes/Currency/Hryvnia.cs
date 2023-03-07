using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02.Classes.Currency
{
    public class Hryvnia : Money
    {
        public double DollarCoefficient { get; protected set; }
        public Hryvnia(int cash, int coins) : base(cash, coins)
        {
           
        }

        protected override void _setName()
        {
            Name = "UAH";
        }
        protected override void _setDollarCoefficient()
        {
            DollarCoefficient = 39.05;
        }
    }
}
