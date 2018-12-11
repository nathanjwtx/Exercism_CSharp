using System;

public struct ComplexNumber
{
    private double _real;
    private double _imaginary;
    private double _i;
    public ComplexNumber(double real, double imaginary)
    {
        _real = real;
        _imaginary = imaginary;
        _i = -1;
    }

    public double Real()
    {
        return _real;
    }

    public double Imaginary()
    {
        return _imaginary;
    }

    public ComplexNumber Mul(ComplexNumber other)
    {
        var firsts = _real * other._real;
        var outers = _real * other._imaginary;
        var inners = _imaginary * other._real;
        var lasts = _imaginary * other._imaginary * -1;
        return new ComplexNumber(firsts + lasts, outers + inners);
    }

    public ComplexNumber Add(ComplexNumber other)
    {
        return new ComplexNumber(_real + other._real, _imaginary + other._imaginary);
    }

    public ComplexNumber Sub(ComplexNumber other)
    {
        return new ComplexNumber(_real - other._real, _imaginary - other._imaginary);
    }

    public ComplexNumber Div(ComplexNumber other)
    {
        var con = other.Conjugate();

        var numFirsts = _real * con._real;
        var numOuters = _real * con._imaginary;
        var numInners = _imaginary * con._real;
        var numLasts = _imaginary * con._imaginary * -1;

        var domFirsts = other._real * con._real;
        var domOuters = other._real * con._imaginary; // not required as it cancels out domInners
        var domInners = other._imaginary * con._real; // see above
        var domLasts = other._imaginary * con._imaginary * -1;

        var numA = numFirsts + numLasts;
        var numB = numOuters + numInners;
        var dom = domFirsts + domLasts;

        return new ComplexNumber(numA / dom, numB / dom);
    }

    public double Abs()
    {
        return Math.Sqrt(_real * _real + _imaginary * _imaginary);
    }

    public ComplexNumber Conjugate()
    {
        return new ComplexNumber(_real, _imaginary * -1);
    }
    
    public ComplexNumber Exp()
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}