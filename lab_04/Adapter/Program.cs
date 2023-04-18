namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileWriter fileWriter = new FileWriter();
            FileLogger fileLogger = new FileLogger(fileWriter);

            fileLogger.Log("Just a log");
            fileLogger.Warn("Just a warn");
            fileLogger.Error("Just a error");
        }
    }
}