using System;
using System.Linq;

namespace MinEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new []{' '},StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            numbers = numbers
                .Where(n => n % 2 == 0)
                .ToList();
            
            if (numbers.Count==0)
            {
                Console.WriteLine("No match");
            }
            else
            {
                Console.WriteLine($"{numbers.Min():f2}");
            }
        }
    }
}
