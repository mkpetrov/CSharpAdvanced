using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Of_Predicates
{
    class ListOfPredicates
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var numbers = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            var divisibleNumbers=new List<int>();

            for (int i = 1; i <=n; i++)
            {

                var count = 0;
                foreach (var number in numbers)
                {
                    if (i%number==0)
                    {

                        count++;
                    }
                    else
                    {
                        break;
                    }
                    if (count==numbers.Length)
                    {
                        if (i % numbers[count-1] == 0)
                        {
                            divisibleNumbers.Add(i);
                        }
                        else
                        {
                            break;
                        }
                        
                    }
                    
                }
            }

            Console.WriteLine(string.Join(" ",divisibleNumbers));
        }
    }
}
