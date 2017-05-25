using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    public class BasicStackOperations
    {
        public static void Main(string[] args)
        {
            var commands = Console.ReadLine().Split(' ');
            var S = int.Parse(commands[1]);
            var X = int.Parse(commands[2]);
            var stack=new Stack<int>();

            var input = Console.ReadLine().Split(' ').Select(int.Parse);

            foreach (var entry in input)
            {
                stack.Push(entry);
            }
            for (int i = 0; i < S; i++)
            {
                stack.Pop();
            }

            var isPresent = stack.Contains(X);

            if (isPresent)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Count == 0 ? 0 : stack.Min());
            }
        }
    }
}
