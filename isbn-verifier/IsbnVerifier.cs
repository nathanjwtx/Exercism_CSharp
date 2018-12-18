using System;
using System.Linq;

public static class IsbnVerifier
{
    public static bool IsValid(string number)
    {
        var noDash = number.Replace("-", "");
        Console.WriteLine(noDash);

        if (noDash.Length != 10)
        {
            return false;
        }

        double result = 0;

        for (int i = 10; i > 1; i--)
        {
            if (!char.IsNumber(noDash[10-i]))
            {
                return false;
            }
            result += char.GetNumericValue(noDash[10 - i]) * i;
        }

        if (noDash[9] == 'X')
        {
            result += 10;
        }
        else if (char.IsNumber(noDash[9]))
        {
            result += (char.GetNumericValue(noDash[9]));
        }

        Console.WriteLine(result % 11);

        if (result % 11 == 0.0)
        {
            return true;
        }
        return false;
    }
}