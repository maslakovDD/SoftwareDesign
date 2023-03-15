using lab_03.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_03.Creators
{
    public class DomesticSubscriptionCreator : SubscriptionCreator
    {
        public override ISubscription CreateSubscription(int period)
        {
            List<string> channels = new List<string>();
            channels.Add("1+1");
            channels.Add("Novyi");
            channels.Add("STB");
            if (period >= DomesticSubscription.MinPeriod)
                return new DomesticSubscription(period, channels);
            else
                return new DomesticSubscription(DomesticSubscription.MinPeriod, channels);
        }
    }
}
