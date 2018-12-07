using System;
using System.Linq;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        var reversed = "";
        foreach (char c in input)
        {
            reversed = c + reversed;
        }

//        input.ToCharArray().Reverse().ToArray();
        return reversed;
    }
}