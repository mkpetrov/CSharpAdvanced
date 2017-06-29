using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeakStudents
{
    class WeakStudents
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var weakStudents=new List<string>();

            while (input!="END")
            {
                var inputParts = input.Split(' ');

                var grades = inputParts.Skip(2).ToList();

                var count = 0;
                foreach (var grade in grades)
                {
                    if (grade=="2"||grade=="3")
                    {
                        count++;
                    }
                }

                if (count>1)
                {
                    weakStudents.Add($"{inputParts[0]} {inputParts[1]}");
                }

                input = Console.ReadLine();
            }

            foreach (var student in weakStudents)
            {
                Console.WriteLine(student);
            }
        }
    }
}
