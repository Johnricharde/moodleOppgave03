using System.Diagnostics.CodeAnalysis;

namespace moodleOppgave03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            decimal b = 3.0m;

            // Variabelen må enten være:
            decimal sum = a + b;
            // Eller:
            var sumAlternativ = a + b;

            Console.WriteLine(sum);
            Console.WriteLine(sumAlternativ);

            Console.ReadKey();
        }
    }
}