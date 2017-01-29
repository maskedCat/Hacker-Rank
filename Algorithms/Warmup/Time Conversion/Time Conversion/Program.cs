using System;
using System.Globalization;

namespace Time_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string time = Console.ReadLine();
            const string inputFormat = "hh:mm:sstt";
            const string outputFormat = "HH:mm:ss";
            var dateTime = DateTime.ParseExact(time, inputFormat, CultureInfo.CurrentCulture);
            Console.WriteLine(dateTime.ToString(outputFormat));
        }
    }
}
