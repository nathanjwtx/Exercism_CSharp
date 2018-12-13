using System;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = PrimeFactors.Factors(93819012551);

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
