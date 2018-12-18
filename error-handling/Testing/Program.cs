using System;
using static ErrorHandling;

namespace Testing
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HandleErrorByReturningNullableType("1"));

            var dispObj = new DisposableResource();

            DisposableResourcesAreDisposedWhenExceptionIsThrown(dispObj);
        }
    }

    public class DisposableResource : IDisposable
    {
        public bool IsDisposed { get; private set; }

        public void Dispose()
        {
            IsDisposed = true;
            GC.SuppressFinalize(this);
        }
    }
}
