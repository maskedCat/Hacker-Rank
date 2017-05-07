using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;
using System.Threading.Tasks;

namespace Staircase
{
    class Program
    {
        static void Main(String[] args)
        {
            int _n;
            _n = Convert.ToInt32(Console.ReadLine());

            StairCase(_n);

        }

       

        /*
 * Complete the function below.
 */
        static void StairCase(int n)
        {
            var numberOfSpaces = n - 1;

            var currentLine = new System.Text.StringBuilder();

            for (var i = 0; i < numberOfSpaces; i++)
            {
                currentLine.Append(' ');
            }
            currentLine.Append('#');

            //Console.WriteLine(currentLine.ToString());

            for (var i = numberOfSpaces; i > -1; i--)
            {
                currentLine[i] = '#';
                Console.WriteLine(currentLine.ToString());
            }
        }

    }
}

