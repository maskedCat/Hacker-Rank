using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
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

        insertionSort(_ar);
    }

    static void insertionSort(int[] ar)
    {
        var i = ar.Length - 1;
        var j = i - 1;

        var e = ar[i];

        while(true)
        {
            var a = ar[j];

            if (e > a)
                break;






            
            

        }





    }
}

