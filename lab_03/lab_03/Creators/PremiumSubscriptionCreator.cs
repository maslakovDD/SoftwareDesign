using lab_03.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_03.Creators
{
    public class PremiumSubscriptionCreator : SubscriptionCreator
    {
        public override ISubscription CreateSubscription(int period)
        {
            List<string> channels = new List<string>();
            channels.Add("Paramount");
            channels.Add("Fox");
            channels.Add("HBO");
            if (period >= PremiumSubscription.MinPeriod)
                return new PremiumSubscription(period, channels);
            else
                return new PremiumSubscription(PremiumSubscription.MinPeriod, channels);
        }
    }
}
