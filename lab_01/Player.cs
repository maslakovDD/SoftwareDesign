using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_01
{
    public class Player
    {

        public string Sign { get; set; }
        public int Wins { get; set; }
        public string Name { get; set; }

        public Player(string name, string sign)
        {
            Name = name;
            Sign = sign;
            Wins = 0;
        }

    }
}
