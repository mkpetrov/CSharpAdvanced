using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSameValuesInArray
{
    class CountSameValuesInArray
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var counter=new SortedDictionary<double,int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!counter.ContainsKey(input[i]))
                {
                    counter[input[i]] = 0;
                }
                counter[input[i]]++;
            }

            foreach (var entry in counter)
            {
                Console.WriteLine($"{entry.Key} - {entry.Value} times");
            }
        }
    }
}
