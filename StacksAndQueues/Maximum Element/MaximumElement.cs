using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_Element
{
    public class MaximumElement
    {
        public static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var stack=new Stack<int>();

            for (int i = 0; i < N; i++)
            {
                var input = Console.ReadLine().Split(' ');

                if (input.Length==2)
                {
                    stack.Push(int.Parse(input[1]));
                }
                else
                {
                    if (int.Parse(input[0])==2)
                    {
                        stack.Pop();
                    }
                    if (int.Parse(input[0])==3)
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
            }
        }
    }
}
