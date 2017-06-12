using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicode_Characters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            foreach (char c in input)
            {
                sb.Append("\\u");
                sb.Append(String.Format("{0:x4}", (int)c));
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
