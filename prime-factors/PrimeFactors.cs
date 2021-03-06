using System;
using System.Collections;
using System.Collections.Generic;

public static class PrimeFactors
{
    public static List<int> Primes = new List<int>();
    private static long PreviousNumber = 0;
    
    public static int[] Factors(long number)
    {
        if (number == 1)
        {
            return Primes.ToArray();
        }
        for (var i = 2; i <= number; i++)
        {
            if (number > PreviousNumber && PreviousNumber != 0)
            {
                break;
            }
            if (number % i == 0)
            {
                Primes.Add(i);
                PreviousNumber = number;
                Factors(number / i);
            }
        }

        return Primes.ToArray();
    }
    
    // alternative solution without recursion
    public static IEnumerable<long> For( long i )
    {
        int factor = 2;
        while ( i > 1 )
        {
            while ( i % factor != 0 ) factor++;
            i /= factor;
            yield return factor;
        }
    }
}