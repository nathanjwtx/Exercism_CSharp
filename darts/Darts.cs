using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
        if (x >= 0 && x <= 1 && y >= 0 && y <= 1)
        {
            return 10;
        }
        if (x >= 0 && x <= 5 && y >=0 && y <= 5)
        {
            return 5;
        }
        if (x >= 0 && x <= 10 && y >= 0 && y <= 10)
        {
            return 1;
        }
        return 0;
    }
}
