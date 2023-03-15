using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_03.Subscriptions
{
    public class PremiumSubscription : ISubscription
    {
        public string _name { get; set; }
        public int Period { get; set; }
        public double MonthlyFee { get; set; } = 200;
        public static int MinPeriod { get; set; } = 6;
        public List<string> Channels { get; set; }

        public PremiumSubscription(int period, List<string> channels)
        {
            _name = "Premium";
            Period = period;
            Channels = channels;
        }
        public string GetName()
        {
            return _name;
        }
    }
}
