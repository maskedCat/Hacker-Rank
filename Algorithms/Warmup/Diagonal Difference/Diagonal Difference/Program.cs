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
                       
            do
            {
                var 
                n--;
            } while (n > 0);

        }

        private static int[] ConvertToArray(string input)
        {
            return Array.ConvertAll(input.Split(' '), Int32.Parse);
        }
    }
}
