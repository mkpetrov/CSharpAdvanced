using System;
using System.Linq;

namespace Average_of_Doubles
{
    class AverageOfDoubles
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            Console.WriteLine($"{numbers.Average():f2}");
        }
    }
}
