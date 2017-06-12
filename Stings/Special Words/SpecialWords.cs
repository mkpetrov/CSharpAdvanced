using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Words
{
    class SpecialWords
    {
        static void Main(string[] args)
        {
            var specialwords = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            var specialWordsList=new Dictionary<string,int>();
            foreach (var word in specialwords)
            {
                specialWordsList.Add(word,0);
            }

            var inputLine = Console.ReadLine().Split(new[] {'(', ')', '{', '}', '<', '>', '-', '?', '!', ' '},
                StringSplitOptions.RemoveEmptyEntries);

            foreach (var kvp in inputLine)
            {
                if (specialWordsList.ContainsKey(kvp))
                {
                    specialWordsList[kvp]++;
                }
            }

            foreach (var word in specialWordsList)
            {
                var currentWord = word.Key;
                var count = word.Value;
                Console.WriteLine($"{currentWord} - {count}");
            }
        }
    }
}
