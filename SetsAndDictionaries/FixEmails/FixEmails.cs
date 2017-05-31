using System;
using System.Collections.Generic;

namespace FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();

            var emails=new Dictionary<string,string>();

            while (name!="stop")
            {
                var email = Console.ReadLine();

                var emailCheck = email.Split('.');
                var domain = emailCheck[1];

                if (domain.Contains("bg"))
                {
                    emails[name] = email;
                }

                name = Console.ReadLine();
            }

            foreach (var email in emails)
            {
                Console.WriteLine($"{email.Key} -> {email.Value}");
            }
        }
    }
}
