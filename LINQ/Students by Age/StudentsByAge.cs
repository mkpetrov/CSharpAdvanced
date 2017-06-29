using System;
using System.Collections.Generic;

namespace Students_by_Age
{
    class StudentsByAge
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var output=new List<string>();

            while (input!="END")
            {
                var inputParts = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var age = int.Parse(inputParts[2]);

                if (age>=18 && age<=24)
                {
                    output.Add($"{inputParts[0]} {inputParts[1]} {age}");
                }

                input = Console.ReadLine();
            }

            foreach (var name in output)
            {
                Console.WriteLine(name);
            }
        }
    }
}
