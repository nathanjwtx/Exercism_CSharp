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
        throw new NotImplementedException("You need to implement this function.");
    }

    public double Abs()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public ComplexNumber Conjugate()
    {
        throw new NotImplementedException("You need to implement this function.");
    }
    
    public ComplexNumber Exp()
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}