using System;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = LargestSeriesProduct.GetLargestProduct("123456", 6);

            Console.WriteLine(result);
        }
    }
}
