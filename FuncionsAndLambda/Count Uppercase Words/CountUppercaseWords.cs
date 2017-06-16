using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Uppercase_Words
{
    class CountUppercaseWords
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            var output=new List<string>();

            foreach (var kvp in input)
            {
                if (kvp[0]>=65 && kvp[0]<=90)
                {
                    output.Add(kvp);
                }
            }

            foreach (var word in output)
            {
                Console.WriteLine(word);
            }
        }
    }
}
