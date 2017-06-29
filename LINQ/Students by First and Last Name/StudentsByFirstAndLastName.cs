using System;
using System.Collections.Generic;

namespace Students_by_First_and_Last_Name
{
    class StudentsByFirstAndLastName
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var listOfNames=new List<string>();

            while (input!="END")
            {
                var inputParts = input.Split(new []{' '},StringSplitOptions.RemoveEmptyEntries);
                var firstName = inputParts[0];
                var lastName = inputParts[1];

                if (firstName[0]<=lastName[0])
                {
                    listOfNames.Add($"{firstName} {lastName}");
                }
                input = Console.ReadLine();
            }
            foreach (var name in listOfNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
