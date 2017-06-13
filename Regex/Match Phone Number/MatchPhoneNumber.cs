using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Match_Phone_Number
{
    class MatchPhoneNumber
    {
        static void Main(string[] args)
        {
            var inputNumber = Console.ReadLine();

            while (inputNumber!="end")
            {
                var regex=new Regex(@"\+359 2 \d{3} \d{4}|\+359-2-\d{3}-\d{4}\b");

                var isMatch = regex.IsMatch(inputNumber);

                if (isMatch)
                {
                    Console.WriteLine(inputNumber);
                }

                inputNumber = Console.ReadLine();
            }
        }
    }
}
