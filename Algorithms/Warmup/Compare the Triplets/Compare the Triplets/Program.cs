using System;

namespace Compare_the_Triplets
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = ConvertToArray(Console.ReadLine());
            var b = ConvertToArray(Console.ReadLine());

            var scores = CalculateScores(a, b);
            Console.WriteLine(string.Join(" ", scores.ScoreA, scores.ScoreB));
        }

        private static int[] ConvertToArray(string input)
        {
            return  Array.ConvertAll(input.Split(' '), Int32.Parse);
        }

        private static Result CalculateScores(int[] a, int[]b)
        {
            var result = new Result();

            for(var i =0; i< a.Length; i++)
            {
                var elementA = a[i];
                var elementB = b[i];

                if(elementA > elementB)
                {
                    result.ScoreA++;
                }
                else if(elementB > elementA)
                {
                    result.ScoreB++;
                }
            }

            return result;
        }
    }

    struct Result
    {
        public int ScoreA { get; set; }
        public int ScoreB { get; set; }
    }
}
