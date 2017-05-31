using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unique_Usernames
{
    public class UniqueUsernames
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var usernames=new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                usernames.Add(input);
            }

            foreach (var user in usernames)
            {
                Console.WriteLine(user);
            }
        }
    }
}
