using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Numbers
{
    class SumNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            Console.WriteLine(input.Count());
            Console.WriteLine(input.Sum());
        }
    }
}
