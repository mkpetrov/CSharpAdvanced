using System;
using System.Collections.Generic;
using System.Linq;

namespace Legendary_Farming
{
    class LegendaryFarming
    {
        static void Main(string[] args)
        {
            
            var junk=new SortedDictionary<string,int>();
            var legendaryMaterials=new Dictionary<string,int>();

            var shards = "shards";
            var fragments = "fragments";
            var motes = "motes";

            legendaryMaterials.Add(shards,0);
            legendaryMaterials.Add(fragments,0);
            legendaryMaterials.Add(motes,0);

            var input = Console.ReadLine();

            while (true)
            {
                var tokens = input.Split(' ').ToArray();
                var legendaryFound = false;
                for (int i = 0; i < tokens.Length; i++)
                {
                    if (i%2==0)
                    {
                        var count = int.Parse(tokens[i]);
                        var material = tokens[i + 1].ToLower();

                        if (material=="shards"||material=="fragments"||material=="motes")
                        {
                            switch (material)
                            {
                                case "shards":
                                    legendaryMaterials[shards] += count;
                                    break;
                                case "fragments":
                                    legendaryMaterials[fragments] += count;
                                    break;
                                case "motes":
                                    legendaryMaterials[motes] += count;
                                    break;
                            }
                            if (legendaryMaterials[shards] > 250 || legendaryMaterials[fragments] > 250 || legendaryMaterials[motes] > 250)
                            {
                                legendaryFound = true;
;                            }
                        }
                        else
                        {
                            if (!junk.ContainsKey(material))
                            {
                                junk[material] = 0;
                            }
                            junk[material] += count;
                        }

                    }
                    if (legendaryFound)
                    {
                        break;
                    }
                    
                }
                if (legendaryFound)
                {
                    break;
                }
                input = Console.ReadLine();
            }

            if (legendaryMaterials[shards] > 250)
            {
                legendaryMaterials[shards] -= 250;
                legendaryMaterials = legendaryMaterials.OrderByDescending(x => x.Value).ThenBy(x=>x.Key)
                    .ToDictionary(x => x.Key, x => x.Value);

                Console.WriteLine("Shadowmourne obtained!");
                foreach (var material in legendaryMaterials)
                {
                    Console.WriteLine($"{material.Key}: {material.Value}");
                }

                foreach (var kvp in junk)
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                }
            }
            else if (legendaryMaterials[fragments] > 250)
            {
                legendaryMaterials[fragments] -= 250;
                legendaryMaterials = legendaryMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key)
                    .ToDictionary(x => x.Key, x => x.Value);

                Console.WriteLine("Valanyr obtained!");

                foreach (var material in legendaryMaterials)
                {
                    Console.WriteLine($"{material.Key}: {material.Value}");
                }

                foreach (var kvp in junk)
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                }
            }
            else if (legendaryMaterials[motes] > 250)
            {
                legendaryMaterials[motes] -= 250;
                legendaryMaterials = legendaryMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key)
                    .ToDictionary(x => x.Key, x => x.Value);

                Console.WriteLine("Dragonwrath obtained!");

                foreach (var material in legendaryMaterials)
                {
                    Console.WriteLine($"{material.Key}: {material.Value}");
                }

                foreach (var kvp in junk)
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                }
            }
        }
    }
}
