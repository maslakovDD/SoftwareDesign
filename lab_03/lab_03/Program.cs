using lab_03.Subscriptions;

namespace lab_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISubscription? currentSubscription =  ManagerCall.BuySubscription();
            PrintSubscription(currentSubscription);
            currentSubscription = MobileApp.BuySubscription();
            PrintSubscription(currentSubscription);
        }

        static void PrintSubscription(ISubscription? subscription)
        {
            if (subscription != null)
            {
                Console.WriteLine(
                    $"Current subscription: {subscription.GetName()}\n" +
                    $"Price: {subscription.MonthlyFee} per month\n" +
                    $"Subscribing period: {subscription.Period} months\n" +
                    $"Channels: ");
                foreach (var channel in subscription.Channels)
                {

                    Console.WriteLine(channel);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("You haven`t any subscription!");
            }
        }
    }
}