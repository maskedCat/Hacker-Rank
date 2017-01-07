using System;
using System.Linq;

namespace Simple_Array_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var arrayRaw = Console.ReadLine().Split(' ');
            var array = Array.ConvertAll<string, int>(arrayRaw, Int32.Parse);
            var sum = array.Sum();
            Console.WriteLine(sum);
        }
    }
}
