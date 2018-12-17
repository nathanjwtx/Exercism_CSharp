using System;
using System.Collections.Generic;
using System.Linq;

public class Anagram
{
    private readonly string _baseWord;
    public Anagram(string baseWord)
    {
        _baseWord = baseWord;
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
        List<string> result = new List<string>();

        var word = _baseWord.ToUpper().ToList();
        word.Sort();

        foreach (string match in potentialMatches)
        {
            if (match == _baseWord)
            {
                break;
            }
            if (match.Length == word.Count)
            {
                var temp = match.ToUpper().ToList();
                temp.Sort();

                if (string.Join("", word) == string.Join("", temp))
                {
                    result.Add(match);
                }
            }
        }
        return result.ToArray();
    }
}