using System;
using System.Diagnostics.CodeAnalysis;
using Xunit.Sdk;

[SuppressMessage("ReSharper", "CompareOfFloatsByEqualityOperator")]
public static class Triangle
{
    public static bool IsScalene(double side1, double side2, double side3)
    {
        if (!CheckZero(side1, side2, side3)) return false;

        if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
        {
            return side1 != side2 && side1 != side3 && side2 != side3;
        }
        return false;
    }

    public static bool IsIsosceles(double side1, double side2, double side3)
    {
        if (!CheckZero(side1, side2, side3)) return false;

        if (side1.Equals(side2) && side1 + side2 > side3 || side1.Equals(side3) && side1 + side3 > side2 
            || side2.Equals(side3) && side2 + side3 > side1)
        {
            return true;
        }
        return false;
    }

    public static bool IsEquilateral(double side1, double side2, double side3)
    {
        if (!CheckZero(side1, side2, side3))
        {
            return false;
        }

        if (side1.Equals(side2) && side2.Equals(side3) && side3.Equals(side1))
        {
            return true;
        }
        return false;
    }

    private static bool CheckZero(double side1, double side2, double side3)
    {
        return side1 != 0 && side2 != 0 && side3 != 0;
    }

}

public class TriangleException : Exception { }