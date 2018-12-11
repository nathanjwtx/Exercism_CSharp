using System;
using System.Linq;
using Xunit.Sdk;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span)
    {
        var result = 0;
        var temp = 0;
        for (int i = 0; i < digits.Length - span; i++)
        {
            var sub = digits.Substring(i, span);
            temp = digits.Substring(i, span).Aggregate(1, (acc, val) => acc * val);
            Console.WriteLine(sub);
//            temp = 0;
//            for (int j = 0; j < span; j++)
//            {
//                temp += digits[i + j];
//            }
            temp = 0;
        }

        

        return temp;
    }
}