using lab_03.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_03.Creators
{
    public class EducationalSubscriptionCreator : SubscriptionCreator
    {
        public override ISubscription CreateSubscription(int period)
        {
            List<string> channels = new List<string>();
            channels.Add("Discovery");
            channels.Add("History");
            channels.Add("Science");
            if (period >= EducationalSubscription.MinPeriod)
                return new EducationalSubscription(period, channels);
            else
                return new EducationalSubscription(EducationalSubscription.MinPeriod, channels);
        }
    }
}
