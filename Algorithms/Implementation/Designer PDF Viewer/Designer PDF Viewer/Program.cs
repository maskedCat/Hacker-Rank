using System;

namespace Designer_PDF_Viewer
{
    class Program
    {
        static void Main(string[] args)
        {
            const int width = 1;
            
            var heights = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
            var word = Console.ReadLine();

            var currentMaxHeight = 0;
            var numberOfCharacters = 0;
            foreach(var character in word)
            {
                var heightIndex = (int)character - 97;
                var height = heights[heightIndex];
                if (height > currentMaxHeight)
                    currentMaxHeight = height;
                numberOfCharacters++;
            }

            var area = numberOfCharacters * width * currentMaxHeight;
            Console.WriteLine(area);
        }
    }
}
