using System;
using System.Collections.Generic;
using System.Linq;

class Result
{
    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as a parameter.
     */
    public static void plusMinus(List<int> arr)
    {
        // Initialize array
        int n = arr.Count;

        // Initialize array for counters, i.e., positive, negative, and other
        int positiveCount = 0;
        int negativeCount = 0;
        int zeroCount = 0;

        // Loop through array 
        foreach (int num in arr)
        {
            if (num > 0)
                positiveCount++;
            else if (num < 0)
                negativeCount++;
            else
                zeroCount++;
        }

        // Calculate ratio
        double positiveRatio = (double)positiveCount / n;
        double negativeRatio = (double)negativeCount / n;
        double zeroRatio = (double)zeroCount / n;

        // Output to console with 6 decimal places
        Console.WriteLine(positiveRatio.ToString("F6"));
        Console.WriteLine(negativeRatio.ToString("F6"));
        Console.WriteLine(zeroRatio.ToString("F6"));
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