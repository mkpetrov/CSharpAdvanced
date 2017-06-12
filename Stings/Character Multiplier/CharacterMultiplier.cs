using System;

namespace Character_Multiplier
{
    class CharacterMultiplier
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            var firstStr = input[0];
            var secondStr = input[1];
            
            var sum = 0;

            if (firstStr.Length>=secondStr.Length)
            {
                for (int i = 0; i < firstStr.Length; i++)
                {
                    if (i>secondStr.Length-1)
                    {
                        sum += firstStr[i];
                    }
                    else
                    {
                        sum += firstStr[i] * secondStr[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < secondStr.Length; i++)
                {
                    if (i>firstStr.Length-1)
                    {
                        sum += secondStr[i];
                    }
                    else
                    {
                        sum += firstStr[i] * secondStr[i];
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
