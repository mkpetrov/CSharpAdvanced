using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;



namespace Sum_big_numbers
{
    class SumBigNumbers
    {
        static void Main(string[] args)
        {
            var firstNumber = BigInteger.Parse(Console.ReadLine());
            var secondNumber = BigInteger.Parse(Console.ReadLine());

            

            Console.WriteLine(firstNumber+secondNumber);
        }
    }
}
