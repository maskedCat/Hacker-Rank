using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{ 
    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int m = Convert.ToInt32(tokens_n[1]);
        string[] c_temp = Console.ReadLine().Split(' ');
        long[] c = Array.ConvertAll(c_temp, Int64.Parse);
        // Print the number of ways of making change for 'n' units using coins having the values given by 'c'
        long ways = getWays(n, c);
    }

    static long getWays(long n, long[] c)
    {
        

        var uniqueSummations = new List<long>();
        var coins = c.Distinct();

        foreach(var coin in coins)
        {


            if (coin < n)
                uniqueSummations.Add(coin);




        }


    }

    static long count(long[] coins,long m, long n)
    {
        //If n is 0 there is 1 solution (do not include any coins)
        if (n == 0)
            return 1;

        //If n is less than 0 then no solution exists
        if (n < 0)
            return 0;

        //If there are no coins and n is greater than 0, then no solution exists
        if (m <= 0 && n >= 1)
            return 0;

        return count(coins, m - 1, n) + count(coins, m, n - coins[m - 1]);
    }
}