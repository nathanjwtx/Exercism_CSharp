using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var r1 = new RationalNumber(1, 2);
            var r2 = new RationalNumber(-1, 2);

            var result = r1.Add(r2);

            Console.WriteLine(result.Num);
            Console.WriteLine(result.Dom);
        }
    }
}
