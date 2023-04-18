namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Circle(new CircleRender());
            Console.WriteLine(shape.ShowPixels());
        }
    }
}