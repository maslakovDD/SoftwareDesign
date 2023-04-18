namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigMacMenu bigMacMenu = new BigMacMenu("Sprite", "Large");
            Console.WriteLine(bigMacMenu.GetBigMacMenu(true));
        }
    }
}