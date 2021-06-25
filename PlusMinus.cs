using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using static System.Console;

class Result
{
    public static void plusMinus(List<int> arr)
    {
        var  positive=0; 
        var  negative=0;
        var  zero=0;
        for(int i=0;i<arr.Count;i++)
        {
            if(arr[i]>0)
               ++positive;
            else if(arr[i]<0)
               ++negative;
            else
               ++zero;
            
        }
        WriteLine((double)positive/ arr.Count);
        WriteLine((double)negative / arr.Count);
        WriteLine((double)zero/ arr.Count);

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
