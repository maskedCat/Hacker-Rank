using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plus_Minus
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            var numberOfPositive = arr.Count(i => i > 0);
            var numberOfZeros = arr.Count(i => i == 0);
            var numberOfNegatives = n - numberOfPositive - numberOfZeros;

            decimal fractionOfPositive = Decimal.Divide(numberOfPositive,n);
            decimal fractionOfNegatives = Decimal.Divide(numberOfNegatives,n);
            decimal fractionOfZeros = Decimal.Divide(numberOfZeros,n);

            PrintAnswer(fractionOfPositive);
            PrintAnswer(fractionOfNegatives);
            PrintAnswer(fractionOfZeros);
        }

        static void PrintAnswer(decimal result)
        {
            Console.WriteLine(result.ToString("0.000000"));
        }

        
    }
}
