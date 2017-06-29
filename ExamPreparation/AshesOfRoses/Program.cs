using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AshesOfRoses
{
    class Program
    {
        static void Main(string[] args)
        {

            var inputLine = Console.ReadLine();

            var regex = new Regex(@"Grow <([A-Z][a-z]+)> <([a-zA-Z|\d]+)> (\d+)");

            var output = new Dictionary<string, Dictionary<string, long>>();

            while (inputLine != "Icarus, Ignite!")
            {
                if (regex.IsMatch(inputLine))
                {
                    var inputLineParts = regex.Match(inputLine);

                    var regionName = inputLineParts.Groups[1].ToString();
                    var colorName = inputLineParts.Groups[2].ToString();
                    var roseCount = long.Parse(inputLineParts.Groups[3].ToString());

                    if (!output.ContainsKey(regionName))
                    {
                        output[regionName] = new Dictionary<string, long>();
                    }
                    if (!output[regionName].ContainsKey(colorName))
                    {
                        output[regionName][colorName] = 0;
                    }
                    output[regionName][colorName] += roseCount;
                }

                inputLine = Console.ReadLine();
            }

            output = output.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(n => n.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var region in output)
            {
                Console.WriteLine($"{region.Key}");

                var regionOrder = region.Value.OrderBy(c => c.Value).ThenBy(n => n.Key)
                    .ToDictionary(x => x.Key, x => x.Value);

                foreach (var order in regionOrder)
                {
                    Console.WriteLine($"*--{order.Key} | {order.Value}");
                }
            }
        }
    }
}
