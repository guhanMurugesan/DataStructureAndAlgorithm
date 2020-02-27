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

class Trap
{
    public static void Main(string[] args)
    {
        int[] arr = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
        Console.WriteLine(trap(arr.ToList()));
        Console.ReadLine();
    }
    public static int trap(List<int> A)
    {
        int[] lMax = new int[A.Count];
        int[] rMax = new int[A.Count];
        var max = int.MinValue;
        for (int i = 0; i < A.Count; i++)
        {
            max = Math.Max(max, A[i]);
            lMax[i] = max;
        }
        max = int.MinValue;
        for (int i = A.Count - 1; i >= 0; i--)
        {
            max = Math.Max(max, A[i]);
            rMax[i] = max;
        }
        int sum = 0;
        for (int i = 1; i < A.Count - 1; i++)
        {
            sum +=  Math.Min(lMax[i], rMax[i]) - A[i];
        }

        return sum;
    }
}
