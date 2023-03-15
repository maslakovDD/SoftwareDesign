namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var virus = new Virus(100,5,"Virus");
            var virus1 = (Virus) virus.Clone();
            var childVirus = new VirusChild(200,5,"Child", DateTime.Now,(Virus) virus);
            var clone = (VirusChild) childVirus.Clone();
            clone.SetType("Child CLone");
            clone.SetParent(virus1);
            Console.WriteLine(virus.ToString());
            virus1.SetType("Virus1");
            Console.WriteLine(virus1.ToString());
            Console.WriteLine(clone.ToString());
        }
    }
}