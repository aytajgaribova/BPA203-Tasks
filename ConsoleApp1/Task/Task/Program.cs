using System.Dynamic;

namespace _10_AccessModifirsEncupsulationNamespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GET get = new get();
            get.HorsePower = 200;
            System.Console.WriteLine(get.HorsePower);
        }
    }
}