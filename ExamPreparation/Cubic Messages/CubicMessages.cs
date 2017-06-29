using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cubic_Messages
{
    class CubicMessages
    {
        static void Main(string[] args)
        {
            var message = Console.ReadLine();

            var output=new Dictionary<string,string>();

            while (message!="Over!")
            {
                var m = int.Parse(Console.ReadLine());

                var regex=new Regex(@"^(\d+)([a-zA-Z]+)([^a-zA-Z]*$)");
                var matches = regex.Match(message);
                var getMessage = matches.Groups[2].ToString();

                if (regex.IsMatch(message)&&getMessage.Length==m)
                {
                    

                    var numbers = new StringBuilder();
                    var verificationCode=new StringBuilder();

                    foreach (var symbol in matches.Groups[1].ToString())
                    {
                        if (symbol >= 48 && symbol <= 57)
                        {
                            numbers.Append(symbol);
                        }
                    }
                    foreach (var symbol in matches.Groups[3].ToString())
                    {
                        if (symbol >= 48 && symbol <= 57)
                        {
                            numbers.Append(symbol);
                        }
                    }

                    foreach (var number in numbers.ToString())
                    {
                        var realNumber = (int)Char.GetNumericValue(number);

                        if (realNumber>=0 && realNumber<getMessage.Length)
                        {
                            verificationCode.Append(getMessage[realNumber]);
                        }
                        else
                        {
                            verificationCode.Append(" ");
                        }
                    }

                    output.Add(getMessage,verificationCode.ToString());
                }

                message = Console.ReadLine();
            }

            foreach (var kvp in output)
            {
                Console.WriteLine($"{kvp.Key} == {kvp.Value}");
            }
        }
    }
}
