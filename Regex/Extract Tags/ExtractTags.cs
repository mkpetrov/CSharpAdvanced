using System;
using System.Text.RegularExpressions;

namespace Extract_Tags
{
    class ExtractTags
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            while (inputLine!="END")
            {
                var regex=new Regex(@"<.*?>");

                var matches = regex.Matches(inputLine);

                foreach (Match match in matches)
                {
                    Console.WriteLine(match);
                }

                inputLine = Console.ReadLine();
            }
        }
    }
}
