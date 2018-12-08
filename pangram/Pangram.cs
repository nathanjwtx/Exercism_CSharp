using System;
using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        var alphabet = "abcdefghijklmnopqrstuvwxyz";

        foreach (var x in alphabet)
        {
            if (!input.ToLower().Contains(x))
            {
                return false;
            }
        }

        return true;

        //online solution
        //return alphabet.All(input.ToLower().Contains);
    }
}
