using lab_03.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_03.Creators
{
    public abstract class SubscriptionCreator
    {
        public abstract ISubscription CreateSubscription(int period);
    }
}
