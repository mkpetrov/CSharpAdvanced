using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter_Students_by_Email_Domain
{
    class FilterStudentsByEmailDomain
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var output=new List<string>();

            while (input!="END")
            {
                var inputParts = input.Split(' ');
                var email = inputParts[2];

                if (email.Contains("@gmail.com"))
                {
                    output.Add($"{inputParts[0]} {inputParts[1]}");
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in output)
            {
                Console.WriteLine(kvp);
            }
        }
    }
}
