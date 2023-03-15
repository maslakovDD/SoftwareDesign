namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IClothingFactory clothingFactory = new MenClothingFactory();
            IHat hat = clothingFactory.CreateHat();
            Console.WriteLine(hat.Name);
            clothingFactory = new WomenClothingFactory();
            hat = clothingFactory.CreateHat();
            Console.WriteLine(hat.Name);
        }
    }
}