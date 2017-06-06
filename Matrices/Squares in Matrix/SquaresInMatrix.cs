using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squares_in_Matrix
{
    class SquaresInMatrix
    {
        static void Main(string[] args)
        {
            var sizes = Console.ReadLine().Split(new []{' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var matrix = new char[sizes[0]][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
            }

            var count = 0;

            for (int row = 0; row < matrix.Length-1; row++)
            {
                for (int col = 0; col < matrix[row].Length-1; col++)
                {
                    if (matrix[row][col]==matrix[row][col+1] && 
                        matrix[row][col]==matrix[row+1][col] &&
                        matrix[row][col]==matrix[row+1][col+1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
