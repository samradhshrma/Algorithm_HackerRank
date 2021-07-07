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

    /*link: https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem
     * Complete the 'jumpingOnClouds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY c as parameter.
     */

    public static int jumpingOnClouds(List<int> c)
    {
        const int MaxJump = 2;
        var jumpsCount = 0;
        var i = 0;
        bool noJumps = false;
        while(i < c.Count && !noJumps) 
        {
            noJumps = true;
            for(var j = MaxJump; j > 0; j--) 
            {
                if(i + j < c.Count && c[i + j] == 0) 
                {
                    jumpsCount++;
                    i = i + j;
                    noJumps = false;
                    break;
                }
            }
        }
        return jumpsCount;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> c = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(cTemp => Convert.ToInt32(cTemp)).ToList();

        int result = Result.jumpingOnClouds(c);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
