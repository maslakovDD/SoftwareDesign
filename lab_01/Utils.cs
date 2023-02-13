using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_01
{
    public static class Utils
    {
        
        private static bool CheckStringIsInt(string? s)
        {
            int a;
            return int.TryParse(s, out a);
        }

        public static int? GetIntValue(string? s)
        {
            if (CheckStringIsInt(s))
            {
                return int.Parse(s);
            }
            else
            {
                return null; 
            }
        }
    }
}
