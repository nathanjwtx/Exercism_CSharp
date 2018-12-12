using System;
using System.Collections.Generic;
using System.Linq;

public static class Grains
{
    public static ulong Square(int n)
    {
        if (n <= 0 || n > 64)
        {
            throw new ArgumentOutOfRangeException();
        }
        return Convert.ToUInt64(Math.Pow(2, n - 1));
    }

    public static ulong Total()
    {
        var numbers = Enumerable.Range(1, 64).ToList();

        UInt64 result = 0;
        foreach (var number in numbers)
        {
            var temp = Convert.ToUInt64(Math.Pow(2, number - 1));
            result += temp;
        }

        return result;

        // genius solution from exercism
        // works because max value of ulong data type is 2 ^ 64 -1 integers
        // return ulong.MaxValue;
    }
}