using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsByGroup
{
    class StudentsByGroup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var output=new List<string>();
            while (input!="END")
            {

                var inputParts = input.Split(new []{' '},StringSplitOptions.RemoveEmptyEntries);
                var group = inputParts[2];

                if (group=="2")
                {
                    output.Add($"{inputParts[0]} {inputParts[1]}");
                }

                input = Console.ReadLine();
            }

            output = output.OrderBy(n => n).ToList();

            foreach (var name in output)
            {
                Console.WriteLine(name);
            }
        }
    }
}
