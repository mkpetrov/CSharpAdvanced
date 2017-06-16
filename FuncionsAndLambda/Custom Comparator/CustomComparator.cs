using System;
using System.Linq;
using System.Text;

namespace Custom_Comparator
{
    class CustomComparator
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var oddNumbers = numbers.Where(n => n % 2 == 0).OrderBy(n => n).ToArray();
            var evenNumbers = numbers.Where(n => n % 2 != 0).OrderBy(n => n).ToArray();

            var sb=new StringBuilder();

            foreach (var number in oddNumbers)
            {
                sb.Append(number+" ");
            }
            foreach (var number in evenNumbers)
            {
                sb.Append(number + " ");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
