using System;
using System.Linq;

namespace FindAndSumIntegers
{
    class FindAndSumIntegers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(n=>
            {
                long value;
                bool success = long.TryParse(n, out value);
                return new {value, success};
            }).Where(b=>b.success).Select(x=>x.value).ToList();

            

            if (input.Count==0)
            {
                Console.WriteLine("No match");
            }
            else
            {
                Console.WriteLine($"{input.Sum()}");
            }
        }
    }
}
