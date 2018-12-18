using System;

public static class ErrorHandling
{
    public static void HandleErrorByThrowingException()
    {
        throw new Exception("Error");
    }

    public static int? HandleErrorByReturningNullableType(string input)
    {
        int? x = null;
        try
        {
            x = Convert.ToInt32(input);
        }
        catch (Exception e)
        {
            return x;
        }
        
        return x;
    }

    public static bool HandleErrorWithOutParam(string input, out int result)
    {
        try
        {
            result = Convert.ToInt32(input);
            return true;
        }
        catch (Exception e)
        {
            result = 0;
            return false;
        }
    }

    public static void DisposableResourcesAreDisposedWhenExceptionIsThrown(IDisposable disposableObject)
    {
        throw new NotImplementedException();
    }
}
