using System;
using System.Collections.Generic;
using System.Linq;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {

        Dictionary<string, string> transcription = new Dictionary<string, string>
        {
            {"G", "C"}, {"C", "G"}, {"T", "A"}, {"A", "U"}
        };

        var result = "";
        if (string.IsNullOrWhiteSpace(nucleotide))
        {
            result = "";
        }
        else
        {
            for (var i = 0; i < nucleotide.Length; i++)
            {
                result += transcription[i.ToString()];
            }
            
        }

        return result;
    }
}