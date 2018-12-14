using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

public static class RotationalCipher
{
    private const int UpperA = 65;
    private const int UpperZ = 90;
    private const int LowerA = 97;
    private const int LowerZ = 122;

    public static string Rotate(string text, int shiftKey)
    {
        if (shiftKey == 0 || shiftKey == 26)
        {
            return text;
        }

        var result = "";
//        Console.WriteLine((int) 'Y');
        Console.WriteLine((int) 'a');
        foreach (char c in text)
        {
            // check for punctuation or space
            if (char.IsPunctuation(c) || char.IsWhiteSpace(c))
            {
                result += c;
            }
            if ((int) c + shiftKey > 90)
            {
                
                var x = (int) c + shiftKey - UpperZ;
                result += Convert.ToChar(UpperA + x - 1);

            }   
        }

        

//        foreach (var i in interimResult)
//        {
//            result += (char) i;
//        }
        return result;
    }
}