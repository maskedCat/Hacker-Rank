using System;

namespace A_Very_Big_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine();
            var a = ConvertToArray(Console.ReadLine());
            long result = 0;

            foreach(var i in a)
            {
                result += i;
            }

            Console.WriteLine(result);
        }

        private static int[] ConvertToArray(string input)
        {
            return Array.ConvertAll(input.Split(' '), Int32.Parse);
        }
    }
}
