using System;
using System.Collections.Generic;
using System.Linq;

namespace Periodic_Table
{
    class PeriodicTable
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var elements=new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < input.Length; j++)
                {
                    elements.Add(input[j]);
                }
            }

            Console.WriteLine(string.Join(" ",elements));
            
        }
    }
}
