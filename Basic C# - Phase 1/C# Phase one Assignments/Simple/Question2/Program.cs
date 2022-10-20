using  System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Radius");
        double radius = double.Parse(Console.ReadLine());
        double area = 3.14*radius*radius ;
        double perimeter = 2*3.14*radius ;
        System.Console.WriteLine("The Area is {0} and The Perimeter is {1}",area,perimeter);
    }
}