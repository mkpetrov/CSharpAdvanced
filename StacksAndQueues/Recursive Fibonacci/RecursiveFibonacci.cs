using System;
using System.Collections.Generic;

namespace Recursive_Fibonacci
{
    class RecursiveFibonacci
    {
        static void Main(string[] args)
        {
            var wantedNumber = int.Parse(Console.ReadLine());

            var fibonacciSequence=new List<long>();

            fibonacciSequence.Add(1);
            fibonacciSequence.Add(1);

            for (int i = 2; i < 50; i++)
            {
                fibonacciSequence.Add(fibonacciSequence[i-1]+fibonacciSequence[i-2]);
            }

            Console.WriteLine(fibonacciSequence[wantedNumber-1]);
        }
    }
}
