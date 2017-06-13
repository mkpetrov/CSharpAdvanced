using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Valid_Usernames
{
    class ValidUsernames
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            while (inputLine!="END")
            {
                var regex=new Regex(@"^[\w-_]{3,16}$");

                var isMatch = regex.IsMatch(inputLine);

                if (isMatch)
                {
                    
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }

                inputLine = Console.ReadLine();
            }
        }
    }
}
