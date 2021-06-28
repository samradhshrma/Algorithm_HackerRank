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

    public static List<int> gradingStudents(List<int> grades)
    {
        List<int> RoundoffGrades = new List<int>();
        foreach(var grade in grades) 
        {
            var RoundoffGrade = 5 - (grade%5) + grade;
            if(grade < 38) 
                RoundoffGrades.Add(grade);
            else if((RoundoffGrade - grade) < 3) 
                RoundoffGrades.Add(RoundoffGrade);
            else 
                RoundoffGrades.Add(grade);
        }
        return RoundoffGrades;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
