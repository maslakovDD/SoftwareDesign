namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var thread = new Thread(() =>
            {
                DatabaseRepository.GetInstance();
            });
            DatabaseRepository.GetInstance();
        }
    }
}