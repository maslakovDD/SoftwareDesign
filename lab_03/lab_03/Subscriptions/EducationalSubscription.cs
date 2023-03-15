using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_03.Subscriptions
{
    public class EducationalSubscription : ISubscription
    {
        public string _name { get; set; }
        public double MonthlyFee { get; set; } = 150;
        public int Period { get; set; }
        public static int MinPeriod { get; set; } = 4;

        public List<string> Channels { get; set;}

        public EducationalSubscription(int period, List<string> channels)
        {
            _name = "Educational";
            Period = period;
            Channels = channels;
        }
        public string GetName() { return _name; } 
    }
}
