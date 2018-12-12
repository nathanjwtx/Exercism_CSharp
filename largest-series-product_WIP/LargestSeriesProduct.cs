using System;
using System.Collections.Generic;
using System.Linq;
using Xunit.Sdk;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span)
    {
        if (span > digits.Length || span < 0)
        {
            throw new ArgumentException();
        } else if (span == 0)
        {
            return 1;
        }
        var result = 0;
        for (int i = 0; i < digits.Length - span + 1; i++)
        {
            var sub = digits.Substring(i, span).ToList();
            var temp = char.GetNumericValue(sub[0]);
            for (int j = 1; j < sub.Count; j++)
            {
                Double y = 0;
                if (!double.TryParse(sub[j].ToString(), out y))
                {
                    throw new ArgumentException();
                }
                temp = temp * char.GetNumericValue(sub[j]);
                
            }

            if (temp > result)
            {
                result = (int) Convert.ToInt64(temp);
            }
        }
        return result;
    }
}