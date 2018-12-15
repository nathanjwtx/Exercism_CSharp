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

        foreach (char c in text)
        {
            // check for punctuation or space
            if (char.IsPunctuation(c) || char.IsWhiteSpace(c) || char.IsNumber(c))
            {
                result += c;
            }
            // lower case
            else if ((int)c + shiftKey > LowerZ)
            {

                var x = (int)c + shiftKey - LowerZ;
                result += Convert.ToChar(LowerA + x - 1);

            }
            else if ((int)c < LowerZ && (int)c >= LowerA)
            {
                result += Convert.ToChar((int)c + shiftKey);
            }
            // upper case
            else if ((int) c + shiftKey > UpperZ)
            {
                
                var x = (int) c + shiftKey - UpperZ;
                result += Convert.ToChar(UpperA + x - 1);

            }
            else if ((int) c < UpperZ)
            {
                result += Convert.ToChar((int) c + shiftKey);
            }
        }

        // top online solution
        public static string RotateOnline(string text, int shiftKey)
        {
            char Rotate(char c)
            {
                if (!char.IsLetter(c))
                    return c;
                int b = char.IsLower(c) ? 'a' : 'A';
                return (char)(b + ((c - b + shiftKey) % 26));
            }

            return new string(text.Select(Rotate).ToArray());
        }

        return result;
    }
}