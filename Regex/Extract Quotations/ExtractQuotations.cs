using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Extract_Quotations
{
    class ExtractQuotations
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var regex=new Regex(@"'.*?'|"".*?""");

            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                var removedElements = match.ToString();
                var sb=new StringBuilder();

                for (int i = 1; i < removedElements.Length-1; i++)
                {
                    sb.Append(removedElements[i]);
                }

                Console.WriteLine(sb.ToString());
            }
        }
    }
}
