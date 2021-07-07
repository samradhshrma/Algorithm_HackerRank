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

class Result
{

    /*link:https://www.hackerrank.com/challenges/cut-the-sticks/problem
     * Complete the 'cutTheSticks' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static List<int> cutTheSticks(List<int> arr)
    {
        var result = new List<int>();
        arr.Sort();
        int i = 0;
        while(i < arr.Count) 
        {
            result.Add(arr.Count - i);
            int min = arr[i];
            for(int j = 0; j < arr.Count; j++)
            {
                arr[j] = arr[j] - min;
                if(arr[j] == 0) 
                {
                    i = j + 1;
                }
            }
        }
        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> result = Result.cutTheSticks(arr);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
