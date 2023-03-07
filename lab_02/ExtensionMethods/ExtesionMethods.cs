using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02.ExtensionMethods
{
    public static class ExtesionMethods
    {
        public static int NumberCount(this int num)
        {
            int count = 0;
            while(num > 0)
            {
                num/= 10;
                count++;
            }
            return count;
        }

    }
}
