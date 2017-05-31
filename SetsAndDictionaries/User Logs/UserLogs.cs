using System;
using System.Collections.Generic;

namespace User_Logs
{
    class UserLogs
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var output=new SortedDictionary<string,Dictionary<string,int>>();

            while (input!="end")
            {
                var inputParts = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                var ip = inputParts[0].Trim('I','P','=');
                var message = inputParts[1];
                var user = inputParts[2].Split('=');

                if (!output.ContainsKey(user[1]))
                {
                   output[user[1]] =new Dictionary<string, int>(); 
                }

                if (!output[user[1]].ContainsKey(ip))
                {
                    output[user[1]][ip] = 0;
                }
                output[user[1]][ip]++;

                input = Console.ReadLine();
            }

            foreach (var user in output)
            {
                var username = user.Key;
                var ips = user.Value;

                Console.WriteLine($"{username}:");
                var count = 1;
                foreach (var entry in ips)
                {
                    

                    if (count!=ips.Count)
                    {
                        Console.Write($"{entry.Key} => {entry.Value}, ");
                    }
                    else
                    {
                        Console.Write($"{entry.Key} => {entry.Value}.");
                    }
                    count++;
                }
                Console.WriteLine();
            }
        }
    }
}
