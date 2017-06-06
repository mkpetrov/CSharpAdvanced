using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfAllElementsOfMatrix
{
    public class SumOfAllElementsOfMatrix
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[][] matrix=new int[input[0]][];

            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                matrix[rowIndex]=Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            int maxSum = 0;

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    maxSum += matrix[row][col];
                }
            }

            Console.WriteLine(matrix.Length);
            Console.WriteLine(matrix[0].Length);
            Console.WriteLine(maxSum);
        }
    }
}
