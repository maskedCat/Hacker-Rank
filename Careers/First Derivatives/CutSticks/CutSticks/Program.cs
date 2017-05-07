using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace CutSticks
{
    class Program
    {
        static int[] cutSticks(int[] lengths)
        {

            var workingCopy = lengths;
            var cutOperations = new List<int>();

            while (workingCopy.Any(x => x > 0))
            {
                var shortestLength = workingCopy.Where(l => l > 0).Min();
                var sticksCutInThisPass = 0;

                for (int i = 0; i < workingCopy.Length; i++)
                {
                    var currentStick = workingCopy[i];
                    if (currentStick == 0)
                        continue;

                    workingCopy[i] = currentStick - shortestLength;
                    sticksCutInThisPass++;
                }

                cutOperations.Add(sticksCutInThisPass);




            }

            return cutOperations.ToArray();


        }

        static void Main(String[] args)
        {
           var result = cutSticks(new[]{ 5,4,4,2,2,8});
        }
    }
}
