using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_And_Exclude
{
    class ReverseAndExclude
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Reverse().ToArray();

            var number = int.Parse(Console.ReadLine());

            numbers = numbers.Where(n => n % number != 0).ToArray();

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
