using System;
using System.Collections.Generic;
using System.Linq;

namespace Population_Counter
{
    class PopulationCounter
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            var output=new Dictionary<string,Dictionary<string,long>>();

            while (inputLine!="report")
            {
                var inputParts = inputLine.Split('|');
                var cityName = inputParts[0];
                var country = inputParts[1];
                var cityPopulation = long.Parse(inputParts[2]);

                if (!output.ContainsKey(country))
                {
                    output[country]=new Dictionary<string, long>();
                }

                if (!output[country].ContainsKey(cityName))
                {
                    output[country][cityName] = cityPopulation;
                }

                inputLine = Console.ReadLine();
            }

            output = output.OrderByDescending(x => x.Value.Values.Sum()).ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in output)
            {
                var country = kvp.Key;
                var citiesInfo = kvp.Value.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key,x=>x.Value);
                var totalPopulation = kvp.Value.Values.Sum();

                Console.WriteLine($"{country} (total population: {totalPopulation})");

                foreach (var city in citiesInfo)
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
