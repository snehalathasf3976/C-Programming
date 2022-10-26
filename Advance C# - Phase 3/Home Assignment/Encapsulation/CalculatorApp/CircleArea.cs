using System;
using MathsLib;
namespace CalculatorApp;
public class CircleArea : Maths
{
    protected static double s_radius ;
    public double Radius { get; set; }
    internal double Area { get; set; }

    public CircleArea(double radius)
    {
        Radius = radius ;
    }

    public double CalculateCircleArea()
    {
        double area = s_pi * Radius * Radius ;
        System.Console.WriteLine("Area is: "+area);
        return area;
    }
}