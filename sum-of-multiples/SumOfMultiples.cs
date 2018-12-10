using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        List<int> numbers = new List<int>();
        for (int i = 1; i < max; i++)
        {
            numbers.Add(i);
        }

        var interimResult = (from x in numbers
            from y in multiples
            where y != 0 // prevents an error if one of the values in multiples is 0
            where x % y == 0
            select x).ToList();

        var result = interimResult.Distinct().ToList();

        Console.WriteLine(string.Join(", ", interimResult));
        Console.WriteLine(result.Sum());

        return result.Sum();
    }
}