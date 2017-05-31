using System;
using System.Collections.Generic;
using System.Linq;

namespace Logs_Aggregator
{
    class LogsAggregator
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            
            var output=new SortedDictionary<string,SortedDictionary<string,int>>();

            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine().Split(new []{' '},StringSplitOptions.RemoveEmptyEntries);

                var userName = inputLine[1];
                var ip = inputLine[0];
                var duration = int.Parse(inputLine[2]);

                if (!output.ContainsKey(userName))
                {
                    output[userName]=new SortedDictionary<string, int>();
                }

                if (!output[userName].ContainsKey(ip))
                {
                    output[userName][ip] = 0;
                }

                output[userName][ip] +=duration;
            }

            foreach (var user in output)
            {
                var userToDosplay = user.Key;
                var userInfo = user.Value;
                var durationSum = userInfo.Values.Sum();

                Console.Write($"{userToDosplay}: {durationSum} [");
                var count = 1;
                foreach (var entry in userInfo)
                {
                    if (userInfo.Count!=count)
                    {
                        Console.Write($"{entry.Key}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{entry.Key}]");
                    }
                    count++;
                }
            }
        }
    }
}
