using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Evens_or_Odds
{
    class FindEvensOrOdds
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            var command = Console.ReadLine();
            var startingNumber = numbers[0];
            var endNumber = numbers[1];

            var output=new List<int>();

            for (int i = startingNumber; i <= endNumber; i++)
            {
                if (command=="odd")
                {
                    if (i%2!=0)
                    {
                        output.Add(i);
                    }
                }
                else
                {
                    if (i%2==0)
                    {
                        output.Add(i);
                    }
                }
            }

            Console.WriteLine(string.Join(" ",output));
        }
    }
}
