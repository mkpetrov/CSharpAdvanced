using System;
using System.Text.RegularExpressions;

namespace Sentence_Extractor
{
    class SentenceExtractor
    {
        static void Main(string[] args)
        {
            var keyWord = Console.ReadLine();

            var inputLine = Console.ReadLine();

            var regex=new Regex(@"([^.!?]+(?=[.!?])[.!?])");

            var matches = regex.Matches(inputLine);

            foreach (Match match in matches)
            {
                string sentence = match.ToString();

                if (sentence.Contains($" {keyWord} "))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
