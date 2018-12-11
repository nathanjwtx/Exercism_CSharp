using System;
using System.Collections.Generic;
using System.Linq;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        var nums = MakeNumbersList(max);

        return Convert.ToInt32(Math.Pow(nums.Sum(), 2));
    }

    public static int CalculateSumOfSquares(int max)
    {
        var nums = MakeNumbersList(max);

        return Convert.ToInt32(nums.Sum(n => n * n));
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return Convert.ToInt32(Math.Abs(CalculateSumOfSquares(max) - CalculateSquareOfSum(max)));
    }

    private static List<int> MakeNumbersList(int max)
    {
        return Enumerable.Range(1, max).ToList();
    }
}