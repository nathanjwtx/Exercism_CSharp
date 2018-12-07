using System;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        // All whitespace will break helper method
        if (string.IsNullOrWhiteSpace(statement))
        {
            return "Fine. Be that way!";
        }

        string response;
        // test for all upper case - yelling
//        var allUpper = statement.Replace(" ", "").All(c => char.IsLetter(c) && char.IsUpper(c));
//        var allUpper = statement.Any(char.IsLower) && !statement.Any(Char.IsLetter);

        // test for question
        var question = statement.TrimEnd().EndsWith('?');

        // test for at least one letter
        var hasLetter = statement.Any(char.IsLetter);

        if (AllUpper(statement) && question && hasLetter)
        {
            response = "Calm down, I know what I'm doing!";
        }
        else if (AllUpper(statement) && hasLetter)
        {
            response = "Whoa, chill out!";
        }
        else if (question)
        {
            response = "Sure.";
        }
        else
        {
            response = "Whatever.";
        }

        return response;
    }

    public static bool AllUpper(string statement)
    {
        foreach (var c in statement)
        {
            if (!Char.IsUpper(c) && Char.IsLetter(c))
            {
                return false;
            }
        }

        return true;
    }
}