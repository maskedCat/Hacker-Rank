using System;

namespace Staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string currentSteps = string.Empty;
            
            for(int i = n; i > 0; i--)
            {
                currentSteps += "#";
                Console.WriteLine(IndentLeft(i - 1) + currentSteps);
            }
        }

        static string IndentLeft(int n)
        {
            return string.Empty.PadLeft(n);
        }
    }
}
