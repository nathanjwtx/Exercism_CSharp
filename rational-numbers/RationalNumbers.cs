using System;
using System.Diagnostics;


public static class RealNumberExtension
{
    public static double Expreal(this int realNumber, RationalNumber r)
    {
        var p = Math.Pow(realNumber, r.Num);
        var q = (float)1 / r.Dom;
        var result = Math.Pow(p, q);
        Console.WriteLine(result);
        return result;
    }
}

public struct RationalNumber
{
    private readonly int _num;
    private readonly int _dom;

    public int Num => _num;
    public int Dom => _dom;

    public RationalNumber(int numerator, int denominator)
    {
        var GCD = RationalNumber.GCD(numerator, denominator);

        _num = numerator / GCD;
        _dom = denominator / GCD;


    }

    // GCD taken from dipique's solution
    static int GCD(int a, int b) => b == 0 ? a : GCD(b, a % b);

    public RationalNumber Add(RationalNumber r)
    {
        return this + r;
    }

    public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
    {
        var n = (r1._num * r2._dom) + (r1._dom * r2._num);
        var d = r1._dom * r2._dom;
        return new RationalNumber(n, d);
    }

    public RationalNumber Sub(RationalNumber r)
    {
        return this - r;
    }

    public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
    {
        var n = r1._num * r2._dom - r2._num * r1._dom;
        return new RationalNumber(n, r1._dom * r2._dom);
    }

    public RationalNumber Mul(RationalNumber r)
    {
        return this * r;
    }

    public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
    {
        var n = r1._num * r2._num;
        return new RationalNumber(n, r1._dom * r2._dom);
    }

    public RationalNumber Div(RationalNumber r)
    {
        return this / r;
    }

    public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
    {
        return new RationalNumber(r1._num * r2._dom, r1._dom * r2._num);
    }

    public RationalNumber Abs()
    {
        return new RationalNumber(Math.Abs(this._num), Math.Abs(this._dom));
    }

    public RationalNumber Reduce()
    {
        return new RationalNumber(_num, _dom);
    }

    public RationalNumber Exprational(int power)
    {
        return new RationalNumber(Convert.ToInt32(Math.Pow(_num, power)), Convert.ToInt32(Math.Pow(_dom, power)));
    }

    public double Expreal(int baseNumber)
    {
        return baseNumber.Expreal(this);

    }
}