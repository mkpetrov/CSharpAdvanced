using System;
using System.Text.RegularExpressions;

namespace MatchCount
{
    class MatchCount
    {
        static void Main(string[] args)
        {
            var pattern = Console.ReadLine();
            var regex=new Regex(pattern);
            var inputText = Console.ReadLine();

            int count = regex.Matches(inputText).Count;

            Console.WriteLine(count);
        }
    }
}
