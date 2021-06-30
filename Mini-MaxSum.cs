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
    public static void miniMaxSum(List<int> arr)
    {
        var min = long.MaxValue;
        var max = 0L;
        var sum = 0L;
        for (int i = 0; i < arr.Count; i++)
        {
            sum += arr[i];
            if (arr[i] < min)
                min = arr[i];

            if (arr[i] > max)
                max = arr[i];

        }
        WriteLine(string.Format("{0} {1}", sum - max, sum - min));
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
