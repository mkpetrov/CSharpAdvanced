using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicate_For_Names
{
    class PredicateForNames
    {
        static void Main(string[] args)
        {
            var namesLength = int.Parse(Console.ReadLine());

            var names = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            names = names.Where(n => n.Length <= namesLength).ToArray();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
