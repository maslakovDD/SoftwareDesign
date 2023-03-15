using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_03.Subscriptions
{
    public class DomesticSubscription : ISubscription
    {
        public string _name { get; set; }
        public double MonthlyFee { get; set; } = 100;
        public int Period { get; set; }
        public static int MinPeriod { get; set; } = 2;
        public List<string> Channels { get; set; }

        public DomesticSubscription(int period, List<string> channels)
        {
            _name = "Domestic";
            Period = period;
            Channels = channels;
        }

        public string GetName()
        {
            return _name;
        }
    }
}
