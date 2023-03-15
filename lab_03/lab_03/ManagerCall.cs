using lab_03.Creators;
using lab_03.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_03
{
    public class ManagerCall
    {
        public static ISubscription? BuySubscription()
        {
            SubscriptionCreator? creator;
            Console.WriteLine("It`s manager!\nWhich subscription you wish to purchase?\n1 - Domestic\n2 - Educational\n3 - Premium\n");
            switch(int.Parse(Console.ReadLine()))
            {
                case 1:
                    creator = new DomesticSubscriptionCreator();
                    break;
                case 2:
                    creator = new EducationalSubscriptionCreator();    
                    break;
                case 3:
                    creator = new PremiumSubscriptionCreator();
                    break;
                default: creator = null; break;
            }
            if(creator!= null)
            {
                Console.WriteLine("What duration you want to subscribe?");
                int period = int.Parse(Console.ReadLine());
                Console.WriteLine("Ok, I have purchased a subscription");
                return creator.CreateSubscription(period);
            }
            else
            {
                Console.WriteLine("There is no this subscription!");
                return null;
            }
        }
    }
}
