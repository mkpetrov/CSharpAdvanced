using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_of_Palindromes
{
    public class MatrixOfPalindromes
    {
        public static void Main(string[] args)
        {
            var inputSize = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            var matrix = new string[inputSize[0],inputSize[1]];

            for (int row = 0; row < inputSize[0]; row++)
            {
                for (int col = 0; col < inputSize[1]; col++)
                {
                    matrix[row,col]= "" + (char)('a' + row) + (char)('a' + row + col) + (char)('a' + row);
                }
            }

            for (int rowIndex = 0; rowIndex < inputSize[0]; rowIndex++)
            {
                for (int colIndex = 0; colIndex < inputSize[1]; colIndex++)
                {
                    Console.Write(matrix[rowIndex,colIndex]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
