using System;
using System.Linq;

namespace Upper_Strings
{
    class UpperStrings
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            words = words.Select(w => w.ToUpper()).ToArray();

            Console.WriteLine(string.Join(" ",words));
        }
    }
}
