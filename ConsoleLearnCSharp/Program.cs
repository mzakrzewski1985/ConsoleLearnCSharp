using System;

namespace ConsoleLearnCSharp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            Math math = new Math();
            
            int age;
            string? ageValue;
            string? name;

            string? answerValue;
            int answer;
            
            int a = random.Next(1, 10);
            int b = random.Next(1, 10);

            do
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            } while (string.IsNullOrEmpty(name));

            do
            {
                Console.Write("Enter your age: ");
                ageValue = Console.ReadLine();
            } while(string.IsNullOrEmpty(ageValue) || !int.TryParse(ageValue, out age));
            
            Console.WriteLine("Rozwiąż zadanie");
            Console.WriteLine($"Liczba {a} + {b} = ?");

            int currentResults = math.Add(a, b);

            do
            {
                Console.Write("Enter your answer: ");
                answerValue = Console.ReadLine();
            } while (string.IsNullOrEmpty(answerValue) || !int.TryParse(answerValue, out answer));

            Console.WriteLine($"Your answer: {answer}");
            Console.WriteLine($"Correct answer: {currentResults}");
            
            if (answer == currentResults)
            {
                Console.WriteLine("You are correct!");
            }
            else
            {
                Console.WriteLine("You are wrong!");
            }
        }
    }
}

