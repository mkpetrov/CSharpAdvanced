using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Vowel_Count
{
    class VowelCount
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();

            var regex=new Regex(@"[aeiouy]");

            var count = regex.Matches(input).Count;

            Console.WriteLine("Vowels: {0}",count);
        }
    }
}
