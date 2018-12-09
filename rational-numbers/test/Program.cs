using System;
using System.Runtime.InteropServices;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var basenumber = 8;
            var r1 = new RationalNumber(4, 3);

            var result = basenumber.Expreal(r1);
            Console.WriteLine(result);

        }
    }
}
