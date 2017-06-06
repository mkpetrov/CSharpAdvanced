using System;
using System.Linq;

namespace Lego_Blocks
{
    class LegoBlocks
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var firstBlock = new int[n][];
            var secondBlock = new int[n][];

            for (int row = 0; row < n; row++)
            {
              firstBlock[row] = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse).ToArray();
            }
            for (int row = 0; row < n; row++)
            {
                secondBlock[row] = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
            }

            var isEqual = true;
            for (int row = 0; row < n-1; row++)
            {
                if (firstBlock[row].Length+secondBlock[row].Length==firstBlock[row+1].Length+secondBlock[row+1].Length)
                {
                    isEqual = true;
                }
                else
                {
                    isEqual = false;
                    break;
                }
            }


            if (isEqual)
            {
                for (int row = 0; row < n; row++)
                {
                    Console.WriteLine($"[{string.Join(", ",firstBlock[row])}, {string.Join(", ",secondBlock[row].Reverse())}]");
                    
                }
            }
            else
            {
                var sumCells = 0;

                foreach (var row in firstBlock)
                {
                    sumCells += row.Length;
                }
                foreach (var row in secondBlock)
                {
                    sumCells += row.Length;
                }

                Console.WriteLine($"The total number of cells is: {sumCells}");
            }
        }
    }
}
