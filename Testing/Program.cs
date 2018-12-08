using System;
using System.Linq;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            var r1 = new RationalNumber(1, 2);
            var r2 = new RationalNumber(2, 3);

            Console.WriteLine("Result:");
            var res = r1 + r2;

            var res1 = r1.Add(r2);
            Console.WriteLine(String.Join(",", res1._r));

//            Console.WriteLine(res._r[0]);
        }
    }
}
