using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            var output=new Dictionary<string,int>();

            string[] wordsFile = File.ReadAllLines("words.txt");
            string[] textFile = File.ReadAllLines("text.txt");

            for (int i = 0; i < wordsFile.Length; i++)
            {
                foreach (var line in textFile)
                {
                    var currentLine = line.Split(new []{' ','-',',','?','!','.'},StringSplitOptions.RemoveEmptyEntries);

                    for (int j = 0; j < currentLine.Length; j++)
                    {
                        if (currentLine[j].ToLower()==wordsFile[i])
                        {
                            if (!output.ContainsKey(wordsFile[i]))
                            {
                                output[wordsFile[i]] = 0;
                            }
                            output[wordsFile[i]]++;
                        }
                    }
                }
            }
            output = output.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            using (StreamWriter writer=new StreamWriter("results.txt"))
            {
                foreach (var word in output)
                {
                    var currentWord = word.Key;
                    var count = word.Value;

                    writer.WriteLine($"{currentWord} - {count}");
                }
            }
        }
    }
}
