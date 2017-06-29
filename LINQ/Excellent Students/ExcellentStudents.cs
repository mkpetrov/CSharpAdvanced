using System;
using System.Collections.Generic;

namespace Excellent_Students
{
    class ExcellentStudents
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var excellentStudents=new List<string>();

            while (input!="END")
            {
                if (input.Contains("6"))
                {
                    var inputParts = input.Split(' ');
                    
                    excellentStudents.Add($"{inputParts[0]} {inputParts[1]}");
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in excellentStudents)
            {
                Console.WriteLine(kvp);
            }    
        }
    }
}
