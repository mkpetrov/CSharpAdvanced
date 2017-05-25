using System;

namespace Simple_Calculator
{
    public class SimpleCalculator
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (i==0)
                {
                    sum = int.Parse(input[i]);
                }
                if (input[i]=="+")
                {
                    sum += int.Parse(input[i+1]);
                }
                if (input[i]=="-")
                {
                    sum -= int.Parse(input[i + 1]);
                }
            }
            Console.WriteLine(sum);
        }
    }
}
