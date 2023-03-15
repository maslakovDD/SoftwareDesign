using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab_03.Subscriptions
{
    public interface ISubscription
    {
        protected string _name { get; set; }
        public double MonthlyFee { get; set; }
        public static int MinPeriod { protected get; set; }
        public int Period { get; set; }
        public List<string> Channels { get; set; }
        public string GetName() { return _name; }
    }
}
