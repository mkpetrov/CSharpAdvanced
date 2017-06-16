using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter_By_Age
{
    class FilterByAge
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var namesList=new Dictionary<string,int>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries);

                var name = input[0];
                var age = int.Parse(input[1]);

                namesList.Add(name,age);
            }

            var condition = Console.ReadLine();
            var searchingAge = int.Parse(Console.ReadLine());
            var format = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            if (condition=="older")
            {
                foreach (var name in namesList)
                {
                    if (name.Value>=searchingAge)
                    {
                        outputFormat(format, name);
                    }
                }
            }
            else
            {
                foreach (var name in namesList)
                {
                    if (name.Value<searchingAge)
                    {
                        outputFormat(format, name);
                    }
                }
            }
        }

        private static void outputFormat(string[] format, KeyValuePair<string, int> name)
        {
            if (format.Length == 2)
            {
                Console.WriteLine($"{name.Key} - {name.Value}");
            }
            else
            {
                if (format[0] == "name")
                {
                    Console.WriteLine(name.Key);
                }
                else
                {
                    Console.WriteLine(name.Value);
                }
            }
        }
    }
}
