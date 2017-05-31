using System;
using System.Collections.Generic;
using System.Linq;

namespace AcademyGraduation
{
    class AcademyGraduation
    {
        static void Main(string[] args)
        {
            var numberOfStudents = int.Parse(Console.ReadLine());

            var studentsList=new SortedDictionary<string,double[]>();
            for (int i = 0; i < numberOfStudents; i++)
            {
                var student = Console.ReadLine();
                var grades = Console.ReadLine().Split(new []{' '},StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse).ToArray();

                studentsList[student] = grades;
            }

            foreach (var student in studentsList)
            {
                Console.WriteLine($"{student.Key} is graduated with {student.Value.Average()}");
            }
        }
    }
}
