using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var matrix = new int[n, n];

            for (var i = 0; i < n; i++)
            {
                var currentLine = ConvertToArray(Console.ReadLine());
                for (var j = 0; j < currentLine.Length; j++)
                {
                    matrix[i, j] = currentLine[j];
                }
            }

            var primaryDiagonal = CalculatePrimaryDiagonal(matrix, n);
            var secondaryDiagonal = CalculateSecondaryDiagonal(matrix, n);

            var difference = primaryDiagonal - secondaryDiagonal;

            Console.WriteLine(Math.Abs(difference));
        }

        private static int[] ConvertToArray(string input)
        {
            return Array.ConvertAll(input.Split(' '), Int32.Parse);
        }

        private static int CalculatePrimaryDiagonal(int[,] array, int size)
        {
            var total = 0;
            var currentRow = 0;
            var currentColumn = 0;

            do
            {
                total += array[currentRow, currentColumn];
                currentRow++;
                currentColumn++;
            } while (currentRow < size);

            return total;
        }

        private static int CalculateSecondaryDiagonal(int[,] array, int size)
        {
            var total = 0;
            var currentRow = 0;
            var currentColumn = size-1;

            do
            {
                total += array[currentRow, currentColumn];
                currentRow++;
                currentColumn--;
            } while (currentColumn >= 0);

            return total;
        }

       
    }
}
