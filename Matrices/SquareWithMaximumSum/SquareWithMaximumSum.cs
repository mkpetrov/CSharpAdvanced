using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareWithMaximumSum
{
    public class SquareWithMaximumSum
    {
        public static void Main(string[] args)
        {
            var sizes = Console.ReadLine()
                .Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var matrix = new int[sizes[0]][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                
            }

            var maxSquareRow = 0;
            var maxSquareCol = 0;
            var maxSum = int.MinValue;

            for (int row = 0; row < matrix.Length - 1; row++)
            {
                for (int col = 0; col < matrix[row].Length-1; col++)
                {
                    var currentSum = matrix[row][col] + matrix[row][col + 1] + matrix[row + 1][col] +
                                     matrix[row + 1][col + 1];

                    if (currentSum>maxSum)
                    {
                        maxSum = currentSum;
                        maxSquareCol = col;
                        maxSquareRow = row;
                    }
                }
            }

            Console.WriteLine($"{matrix[maxSquareRow][maxSquareCol]} {matrix[maxSquareRow][maxSquareCol+1]}");
            Console.WriteLine($"{matrix[maxSquareRow+1][maxSquareCol]} {matrix[maxSquareRow+1][maxSquareCol + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}
