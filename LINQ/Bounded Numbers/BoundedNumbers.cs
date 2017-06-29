using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bounded_Numbers
{
    class BoundedNumbers
    {
        static void Main(string[] args)
        {
            var range = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(n => n).ToArray();

            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            numbers = numbers.Where(n => n >= range[0] & n <= range[1]).ToList();

            if (numbers.Count>0)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
            
        }
    }
}
