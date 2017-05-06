using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void partition(int[] ar)
    {
        var p = ar[0];
        var left = new List<int>();
        var equal = new List<int>();
        var right = new List<int>();

        foreach(var element in ar)
        {
            if (element < p)
                left.Add(element);

            if

        }


    }
    /* Tail starts here */
    static void Main(String[] args)
    {

        int _ar_size;
        _ar_size = Convert.ToInt32(Console.ReadLine());
        int[] _ar = new int[_ar_size];
        String elements = Console.ReadLine();
        String[] split_elements = elements.Split(' ');
        for (int _ar_i = 0; _ar_i < _ar_size; _ar_i++)
        {
            _ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]);
        }

        partition(_ar);
    }
}
