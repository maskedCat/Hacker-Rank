using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apple_and_Orange
{
    class Program
    {
        static void Main(string[] args)
        {
            var house = ReadLine();
            var trees = ReadLine();
            var count = ReadLine();

            var apples = ReadLine();
            var oranges = ReadLine();

            var s = house[0];
            var t = house[1];

            var a = trees[0];
            var b = trees[1];

            Func<int,bool> isInsideHouse = x => x >= s && x <= t;

            var nApples = apples.Select(i => a + i).Where(isInsideHouse).Count();
            var nOranges = oranges.Select(i => b + i).Where(isInsideHouse).Count();

            Console.WriteLine(nApples);
            Console.WriteLine(nOranges);
        }

        static int[] ReadLine()
        {
            return Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse); 
        }
    }
}
