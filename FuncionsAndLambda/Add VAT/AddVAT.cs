using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_VAT
{
    class AddVAT
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(n => n + n * 0.2);

            foreach (var number in input)
            {
                Console.WriteLine($"{number:f2}");
            }
        }
    }
}
