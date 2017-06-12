using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Length
{
    class StringLength
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var output=new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (i<20)
                {
                    output.Append(input[i]);
                }
                else
                {
                    break;
                }
                
            }

            if (output.Length<20)
            {
                while (output.Length<20)
                {
                    output.Append("*");
                }
                Console.WriteLine(output.ToString());
            }
            else
            {
                Console.WriteLine(output.ToString());
            }
        }
    }
}
