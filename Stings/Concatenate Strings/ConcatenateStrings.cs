using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenate_Strings
{
    class ConcatenateStrings
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var output = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                output.Append(Console.ReadLine());
                output.Append(" ");
            }

            Console.WriteLine(output.ToString());
        }
    }
}
