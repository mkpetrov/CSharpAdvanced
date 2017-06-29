using System;
using System.Collections.Generic;
using System.Linq;

namespace Students_Enrolled_in_2014_or_2015
{
    class StudentsEnrolledIn2014Or2015
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var grades=new List<string>();

            while (input!="END")
            {
                var inputParts = input.Split(' ');

                if (inputParts[0].EndsWith("14") || inputParts[0].EndsWith("15"))
                {
                    var grade = inputParts.Skip(1);

                    var gradesToAdd = string.Empty;
                    foreach (var g in grade)
                    {
                        gradesToAdd += $"{g} ";
                    }
                    grades.Add(gradesToAdd);
                }

                input = Console.ReadLine();
            }

            foreach (var grade in grades)
            {
                Console.WriteLine(grade.Trim());
            }
        }
    }
}
