using System;
using System.Collections.Generic;

namespace Count_Symbols
{
    class CountSymbols
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var counter=new SortedDictionary<char,int>();

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
                Console.WriteLine($"{entry.Key}: {entry.Value} time/s");
            }
        }
    }
}
