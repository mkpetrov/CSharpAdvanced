using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubic_Assault
{
    class CubicAssault
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            var output=new Dictionary<string,Dictionary<string,long>>();

            while (inputLine!= "Count em all")
            {
                var inputParts = inputLine.Split(new [] {" -> "}, StringSplitOptions.RemoveEmptyEntries);

                var regionName = inputParts[0];
                var meteorType = inputParts[1];
                var count = long.Parse(inputParts[2]);

                if (!output.ContainsKey(regionName))
                {
                    output[regionName]=new Dictionary<string, long>();

                    output[regionName].Add("Black",0);
                    output[regionName].Add("Red",0);
                    output[regionName].Add("Green",0);
                }

                
                output[regionName][meteorType] += count;

                switch (meteorType)
                {
                    case "Red":
                        if (output[regionName][meteorType] >= 1000000)
                        {
                            output[regionName]["Black"] += 1;
                            output[regionName][meteorType] -= 1000000;
                        }
                        break;
                    case "Green":
                        if (output[regionName][meteorType]>=1000000)
                        {
                            output[regionName]["Red"] += 1;
                            output[regionName][meteorType] -= 1000000;
                        }
                        break;
                }

                inputLine = Console.ReadLine();
            }

            output = output.OrderByDescending(x => x.Value["Black"])
                .ThenBy(x => x.Key.Length)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var region in output)
            {
                Console.WriteLine(region.Key);

                var meteorTypes = region.Value.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key).ToDictionary(x=>x.Key,x=>x.Value);

                foreach (var s in meteorTypes)
                {
                    Console.WriteLine("-> {0} : {1}", s.Key, s.Value);
                }
            }
        }
    }
}
