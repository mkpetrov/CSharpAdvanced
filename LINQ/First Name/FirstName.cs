using System;
using System.Linq;

namespace First_Name
{
    class FirstName
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).OrderBy(n=>n).ToList();

            var letters = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).OrderBy(w => w);

            var name = string.Empty;
            foreach (var letter in letters)
            {
                name = names.Where(w => w.ToLower().StartsWith(letter.ToLower())).FirstOrDefault();

                if (name!=null)
                {
                    Console.WriteLine(name);
                    break;
                }
            }
            if (name==null)
            {
                Console.WriteLine("No match");
            }

        }
    }
}
