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

    /*link:https://www.hackerrank.com/challenges/counting-valleys/problem?h_r=next-challenge&h_v=zen
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */

    public static int countingValleys(int steps, string path)
    {
        var seaLevel=0;
        var valleyCount = 0;
        var ValleyActive = false;
        char[] arr;
        arr = path.ToCharArray(0, steps);
            for(var i=0; i<steps; i++){
                if(path[i]=='U'){
                    seaLevel++;
                }
                else{
                    seaLevel--;
                }
                if (!ValleyActive && seaLevel < 0)
                {
                    ValleyActive = true;
                }

                if (ValleyActive && seaLevel == 0)
                {
                    valleyCount++;
                    ValleyActive = false;
                }
            }
            return valleyCount;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int steps = Convert.ToInt32(Console.ReadLine().Trim());

        string path = Console.ReadLine();

        int result = Result.countingValleys(steps, path);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
