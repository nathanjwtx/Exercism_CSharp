using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

public static class TwelveDays
{
    private static readonly Dictionary<int, string[]> Verses = new Dictionary<int, string[]>();

    static TwelveDays()
    {
        Verses.Add(1, new[] {"first", "a Partridge in a Pear Tree"});
        Verses.Add(2, new [] {"second", "two Turtle Doves"});
        Verses.Add(3, new []{"third", "three French Hens"});
        Verses.Add(4, new []{"fourth", "four Calling Birds"});
        Verses.Add(5, new []{"fifth", "five Gold Rings"});
        Verses.Add(6, new []{"sixth", "six Geese-a-Laying"});
        Verses.Add(7, new []{"seventh", "Swans-a-Swimming"});
        Verses.Add(8, new []{"eighth", "Maids-a-Milking"});
        Verses.Add(9, new []{"ninth", "nine Ladies Dancing"});
        Verses.Add(10, new []{"tenth", "ten Lords-a-Leaping"});
        Verses.Add(11, new []{"eleventh", "eleven Pipers Piping"});
        Verses.Add(12, new []{"twelfth", "twelve Drummers Drumming"});
    }

    public static string Recite(int verseNumber)
    {
        return Recite(1, verseNumber);
    }

    public static string Recite(int startVerse, int endVerse)
    {
        var output = "";
        if (endVerse > 1)
        {
            output +=
                $"On the {Verses[startVerse][0]} day of Christmas my true love gave to me: ";
            for (int i = endVerse; i > startVerse; i--)
            {
                output += $" {Verses[i][1]},";
            }

            output += $" and a Partridge in a Pear Tree";
        }
        else
        {
            output += "On the first day of Christmas my true love gave to me: a Partridge in a Pear Tree";
        }

        return output;
    }
}