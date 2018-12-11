using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 10;

            var nums = Enumerable.Range(1, 10).ToList();
            // nums.ForEach(n => Console.WriteLine(n)); can be replaced by below using Method Group
            nums.ForEach(Console.WriteLine);

            var sqSum = Math.Pow(nums.Sum(), 2);
            var sumSq = nums.Sum(n => n * n);

            Console.WriteLine(sqSum);
            Console.WriteLine(sumSq);
        }
    }
}
