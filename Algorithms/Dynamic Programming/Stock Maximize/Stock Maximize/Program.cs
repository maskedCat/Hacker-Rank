using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            string[] prices_temp = Console.ReadLine().Split(' ');
            int[] prices = Array.ConvertAll(prices_temp, Int32.Parse);
            Console.WriteLine(GetMaxProfit(prices));
        }
    }

    static long GetMaxProfit(int[] prices)
    {
        long profit = 0L;
        int maxSoFar = 0;
        for(int i = prices.Length -1; i> -1;i--)
        {
            if(prices[i]> maxSoFar)
            {
                maxSoFar = prices[i];
            }
            profit += maxSoFar - prices[i];
        }
        return profit;
    }

    
    
}