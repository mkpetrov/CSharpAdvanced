using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidUsernames
{
    class ValidUsernames
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            var regex=new Regex(@"(?<=[\s\/\\(\)]|^)([A-Za-z]\w{2,24})(?=[\s\/\\(\)]|$)");

            var matches = regex.Matches(inputLine);

            var firstUsername = string.Empty;
            var secondUsername = string.Empty;
            var count = int.MinValue;
            

            for (int i = 0; i < matches.Count-1; i++)
            {
                var currentMatch = matches[i];
                var nextMatch = matches[i + 1];
                if (currentMatch.Length+nextMatch.Length>count)
                {
                    firstUsername = currentMatch.ToString();
                    secondUsername = nextMatch.ToString();
                    count=currentMatch.Length+nextMatch.Length;
                }
            }
            Console.WriteLine(firstUsername);
            Console.WriteLine(secondUsername);
        }
    }
}
