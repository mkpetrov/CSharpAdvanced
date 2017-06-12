using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parse_URLs
{
    class ParseURLs
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split(new string[]{"://"},StringSplitOptions.RemoveEmptyEntries);

            if (inputLine.Length!=2 || !inputLine[1].Contains("/"))
            {
                Console.WriteLine("Invalid URL");
            }
            else
            {
                int serverIndex = inputLine[1].IndexOf('/');
                var protocol = inputLine[0];
                var server = inputLine[1].Substring(0,serverIndex);
                var resources = inputLine[1].Substring(serverIndex+1);

                Console.WriteLine($"Protocol = {protocol}");
                Console.WriteLine($"Server = {server}");
                Console.WriteLine($"Resources = {resources}");
            }

            
        }
    }
}
