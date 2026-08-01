using System;

namespace ConsoleLearnCSharp
{
    public static class Program
    {
        public static void Main(string[] arg)
        {
            double a = 20;
            double b = 10;

            Math math = new Math();

            double addResults = math.Add(a, b);
            double subtractResults = math.Subtract(a, b);
            
            Console.WriteLine($"AddResults: {addResults}");
            Console.WriteLine($"SubtractResults: {subtractResults}");
        }
    }
}

