using System;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            var isbn = "3-598-21508-8";

            var number = IsbnVerifier.IsValid(isbn);
            Console.WriteLine(number);
        }
    }
}
