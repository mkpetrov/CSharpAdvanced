using System;
using System.Linq;

namespace Knights_of_Honor
{
    class KnightOfHonor
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var name in names)
            {
                Console.WriteLine($"Sir {name}");
            }
        }
    }
}
