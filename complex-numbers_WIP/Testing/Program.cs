using System;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = new ComplexNumber(1, 2);
            var num1 = new ComplexNumber(3, 4);
            var result = num.Div(num1);
            Console.WriteLine(result.Real());
            Console.WriteLine(result.Imaginary());

        }
    }
}
