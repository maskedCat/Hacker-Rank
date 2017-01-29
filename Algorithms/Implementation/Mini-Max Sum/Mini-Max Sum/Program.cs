using System;
using System.Linq;

namespace Mini_Max_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Array.ConvertAll<string,Int64>(Console.ReadLine().Split(' '),Int64.Parse);

            var orderedInput = input.OrderBy(i => i).ToArray() ;

            var maxSum = orderedInput.Skip(1).Sum();
            var minSum = orderedInput.Take(4).Sum();

            Console.WriteLine(minSum + " " + maxSum);            
        }
    }
}
