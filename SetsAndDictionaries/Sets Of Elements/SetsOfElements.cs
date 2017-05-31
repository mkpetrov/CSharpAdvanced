using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sets_Of_Elements
{
    public class SetsOfElements
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var n = input[0];
            var m = input[1];

            var nSet=new HashSet<int>();
            var mSet=new HashSet<int>();

            for (int i = 0; i < n+m; i++)
            {
                var inputNumber = int.Parse(Console.ReadLine());

                if (i<n)
                {
                    nSet.Add(inputNumber);
                }
                else
                {
                    mSet.Add(inputNumber);
                }
            }
            var repeatedNumbers=new SortedSet<int>();
            foreach (var number in nSet)
            {
                if (mSet.Contains(number))
                {
                    repeatedNumbers.Add(number);
                }
            }
            foreach (var num in repeatedNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
