using System;
using System.Linq;

namespace Diagonal_Difference
{
    public class DiagonalDifference
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var matrix = new int[n][];

            for (int row = 0; row < n; row++)
            {
                matrix[row] = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
            }

            var primaryDiagonalSum = 0;
            var secondaryDiagonalSum = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = row; col < n;)
                {
                    primaryDiagonalSum += matrix[row][col];
                    break;
                }
            }
            var coll = 0;
            for (int row = n-1; row >= 0; row--)
            {
                for (int colIndex = coll; colIndex < n; )
                {
                    secondaryDiagonalSum += matrix[row][coll];
                    coll++;
                    break;
                }
            }
            Console.WriteLine(Math.Abs(primaryDiagonalSum-secondaryDiagonalSum));
        }
    }
}
