using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Match_Full_Name
{
    class MatchFullName
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            while (input!="end")
            {
                var regex=new Regex(@"^[A-Z][a-z]+ [A-Z][a-z]+");

                var isMatch = regex.IsMatch(input);

                if (isMatch)
                {
                    Console.WriteLine(input);
                }

                input = Console.ReadLine();
            }
        }
    }
}
