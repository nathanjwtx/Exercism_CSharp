using System;

public class SpaceAge
{
    private long _seconds;
    private long _earthYearSeconds = 31557600;
    public SpaceAge(long seconds)
    {
        _seconds = seconds;
    }

    public double OnEarth()
    {
        var result = (float)_seconds / _earthYearSeconds;
        return Math.Round(Convert.ToDouble(result), 2);
    }

    public double OnMercury()
    {
        var result = (float) _seconds / (_earthYearSeconds * 0.2408467);
        return Math.Round(Convert.ToDouble(result), 2);
    }

    public double OnVenus()
    {
        var result = (float)_seconds / (_earthYearSeconds * 0.61519726);
        return Math.Round(Convert.ToDouble(result), 2);
    }

    public double OnMars()
    {
        var result = (float) _seconds / (_earthYearSeconds * 1.8808158);
        return Math.Round(Convert.ToDouble(result), 2);
    }

    public double OnJupiter()
    {
        var result = (float) _seconds / (_earthYearSeconds * 11.862615);
        return Math.Round(Convert.ToDouble(result), 2);
    }

    public double OnSaturn()
    {
        var result = (float) _seconds / (_earthYearSeconds * 29.447498);
        return Math.Round(Convert.ToDouble(result), 2);
    }

    public double OnUranus()
    {
        var result = (float) _seconds / (_earthYearSeconds * 84.016846);
        return Math.Round(Convert.ToDouble(result), 2);
    }

    public double OnNeptune()
    {
        var result = (float) _seconds / (_earthYearSeconds * 164.79132);
        return Math.Round(Convert.ToDouble(result), 2);
    }
}