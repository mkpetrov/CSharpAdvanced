using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            var zero = input.Where(x => Math.Abs(x)%3==0).ToArray();
            var one = input.Where(x => Math.Abs(x)%3==1).ToArray();
            var two = input.Where(x => Math.Abs(x)%3==2).ToArray();

            Console.WriteLine(string.Join(" ",zero));
            Console.WriteLine(string.Join(" ",one));
            Console.WriteLine(string.Join(" ",two));
        }
    }
}
