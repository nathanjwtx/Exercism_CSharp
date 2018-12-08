using System;
using System.Diagnostics;


public static class RealNumberExtension
{
    public static double Expreal(this int realNumber, RationalNumber r)
    {
        throw new NotImplementedException("You need to implement this extension method.");
    }
}

public struct RationalNumber
{
    public readonly int[] _r;
    public RationalNumber(int numerator, int denominator)
    {
        _r = new int[2];
        _r[0] = numerator;
        _r[1] = denominator;
    }

    public RationalNumber Add(RationalNumber r)
    {
        return this + r;
    }

    public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
    {
        var n = (r1._r[0] * r2._r[1]) + (r1._r[1] * r2._r[0]);
        var d = r1._r[1] * r2._r[1];
        return new RationalNumber(n, d);
    }

    public RationalNumber Sub(RationalNumber r)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
    {
        throw new NotImplementedException("You need to implement this operator.");
    }

    public RationalNumber Mul(RationalNumber r)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
    {
        throw new NotImplementedException("You need to implement this operator.");
    }

    public RationalNumber Div(RationalNumber r)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
    {
        throw new NotImplementedException("You need to implement this operator.");
    }

    public RationalNumber Abs()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public RationalNumber Reduce()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public RationalNumber Exprational(int power)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public double Expreal(int baseNumber)
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}