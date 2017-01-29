using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circular_Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            int q = Convert.ToInt32(tokens_n[2]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            var b = new List<int>(a);
            var lastIndex = n - 1;

            for(int i = 0; i<k; i++)
            {
                var lastItem = b[lastIndex];
                b.RemoveAt(lastIndex);
                b.Insert(0, lastItem);
            }

            for (int a0 = 0; a0 < q; a0++)
            {
                int m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(b[m]);
            }
        }
    }
}
