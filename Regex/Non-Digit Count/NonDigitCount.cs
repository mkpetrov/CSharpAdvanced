using System;
using System.Text.RegularExpressions;

namespace Vowel_Count
{
    class VowelCount
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();

            var regex = new Regex(@"\D");

            var count = regex.Matches(input).Count;

            Console.WriteLine("Non-digits: {0}", count);
        }
    }
}
