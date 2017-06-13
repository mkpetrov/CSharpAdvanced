using System;
using System.Text.RegularExpressions;

namespace Extract_Integer_Numbers
{
    class ExtractIntegerNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var regex=new Regex(@"\d+");

            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
