using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Extract_Email
{
    class ExtractEmail
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            var regex=new Regex(@"(?<=\s|^)([a-z0-9]+(?:[_.-][a-z0-9]+)*@(?:[a-z]+\-?[a-z]+\.)+[a-z]+\-?[a-z]+)\b");

            var isMatch = regex.IsMatch(inputLine);

            if (isMatch)
            {
                var matches = regex.Matches(inputLine);

                foreach (var match in matches)
                {
                    Console.WriteLine(match);
                }
            }
        }
    }
}
