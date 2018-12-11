using System;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = new ComplexNumber(3, 2);
            var num1 = new ComplexNumber(1, 7);
            var result = num.Mul(num1);
            Console.WriteLine(result.Real());
            Console.WriteLine(result.Imaginary());

        }
    }
}
