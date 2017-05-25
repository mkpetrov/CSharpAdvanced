using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    public class BasicQueueOperations
    {
        public static void Main(string[] args)
        {
            var commands = Console.ReadLine().Split(' ');
            var S = int.Parse(commands[1]);
            var X = int.Parse(commands[2]);
            var queue=new Queue<int>();
            var input = Console.ReadLine().Split(' ').Select(int.Parse);

            foreach (var entry in input)
            {
                queue.Enqueue(entry);
            }

            for (int i = 0; i < S; i++)
            {
                queue.Dequeue();
            }

            var isPresent = queue.Contains(X);

            if (isPresent)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Count == 0 ? 0 : queue.Min());
            }
        }
    }
}
