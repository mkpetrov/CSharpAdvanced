using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace NMS
{
    class NMS
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var inputLine = new StringBuilder();

            var output=new List<string>();

            var message = new StringBuilder();

            while (input!= "---NMS SEND---")
            {
                inputLine.Append(input);
                

                input = Console.ReadLine();
            }

            input = inputLine.ToString();

            for (int i = 0; i <= input.Length - 1; i++)
            {
                if (i == input.Length - 1)
                {
                    message.Append(input[i]);
                    output.Add(message.ToString());
                    break;
                }

                if (char.ToLower(input[i]) <= char.ToLower(input[i + 1]))
                {
                    message.Append(input[i]);

                }
                else
                {
                    message.Append(input[i]);
                    output.Add(message.ToString());
                    message = new StringBuilder();

                }

            }
            var regex=new Regex(Console.ReadLine());

            Console.WriteLine(string.Join($"{regex}",output));
        }
    }
}
