using System;
using System.Collections.Generic;

namespace Balanced_Parenthesis
{
    class BalancedParenthesis
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            var firstPart=new List<char>();
            var secondPart=new List<char>();

            var isEqual = true;

            for (int i = 0; i < inputLine.Length; i++)
            {
                if (i<inputLine.Length/2)
                {
                    firstPart.Add(inputLine[i]);
                }
                else
                {
                    secondPart.Add(inputLine[i]);
                }
            }
            secondPart.Reverse();

            for (int i = 0; i < firstPart.Count; i++)
            {
                if ((firstPart[i]=='('&& secondPart[i]==')') || 
                    (firstPart[i]=='{' && secondPart[i]=='}') ||
                    (firstPart[i]=='[' && secondPart[i]==']'))
                {
                    isEqual = true;
                }
                else
                {
                    isEqual = false;
                }
            }
            if (isEqual)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
