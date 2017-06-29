using System;
using System.Linq;

namespace Take_Two
{
    class TakeTwo
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToList();

            numbers = numbers.Where(n => n >= 10 && n <= 20)
                .Distinct().Take(2).ToList();

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
