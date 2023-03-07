using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02.Interfaces
{
    public interface ICurrency
    {
        public int Cash { get; set; }
        public int Coins { get; set; }
        public string Name { get; }
        public double DollarCoefficient { get; }

    }
}
